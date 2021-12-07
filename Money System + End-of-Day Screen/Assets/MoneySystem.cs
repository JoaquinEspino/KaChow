using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MoneySystem : MonoBehaviour
{
    public float earningsPerDay, tip, incentive, dailyEarnings, totalEarnings, goalAmount;
    public Text earningsPerDayDisplay, tipDisplay, incentiveDisplay, dailyEarningsDisplay, totalEarningsDisplay, goalAmountDisplay, dayDisplay;
    public int numDeliveries, i = 0;
    private float tipProbability = 0;
    public string day;
    public string[] daysOfTheWeek = { "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };

    void Start()
    {
        earningsPerDay = 0;
        goalAmount = 30000;     // To be changed later

        day = "END OF " + daysOfTheWeek[ i ];
        dayDisplay.text = day;

        // Game starts with player having 30% of target amount
        totalEarnings = goalAmount * 0.30f;
        //totalEarnings = PlayerPrefs.GetFloat( "amountEarned" );
    }

    void Update()
    {
        // Updates value of "totalEarnings" per day (per click)
        if ( Input.GetButtonDown( "Fire1" ) )
        {
            // Updates day of the week per click
            i++;
            day = "END OF " + daysOfTheWeek[ i ];

            earningsPerDay = 0;

            numDeliveries = UnityEngine.Random.Range( 3, 8 );     // To be changed later

            earningsPerDay = numDeliveries * 100;

            dailyEarnings += earningsPerDay;

            // Calculation of incentives
            if( numDeliveries >= 6 )
            {
                incentive = UnityEngine.Random.Range( 320, 351 );
            }
            else if( numDeliveries >= 4 && numDeliveries < 6 )
            {
                incentive += UnityEngine.Random.Range( 200, 251 );
            }
            else if( numDeliveries == 3 )
            {
                incentive += 150;
            }

            dailyEarnings += incentive;

            /* 
             * Probabilities of tips
             * 
             * Algorithm for the following code taken from below
             * https://forum.unity.com/threads/making-random-range-generate-a-value-with-probability.336374/
             */

            tipProbability = UnityEngine.Random.Range( 0.0f, 1.0f );

            // Adds customer tips of CTS 0.0 to 20.0 10% of the time
            if( tipProbability <= 0.1f )
            {
                tip = UnityEngine.Random.Range( 0.0f, 21.0f );
            }
            // Adds customer tips of CTS 21.0 to 50.0 50% of the time
            else if( tipProbability <= 0.6f )
            {
                tip = UnityEngine.Random.Range( 21.0f, 51.0f );
            }
            // Adds customer tips of CTS 51.0 to 100.0 20% of the time
            else if( tipProbability <= 0.8f )
            {
                tip = UnityEngine.Random.Range( 51.0f, 101.0f );
            }
            // Adds customer tips of CTS 101.0 to 150.0 10% of the time
            else if( tipProbability <= 0.9f )
            {
                tip = UnityEngine.Random.Range( 101.0f, 151.0f );
            }
            // Adds customer tips of CTS 151.0 to 200.0 10% of the time
            else if( tipProbability <= 1.0f )
            {
                tip = UnityEngine.Random.Range( 151.0f, 201.0f );
            }

            dailyEarnings += tip;

            totalEarnings += dailyEarnings;
            PlayerPrefs.SetFloat( "amountEarned", totalEarnings );
        }

        // Resets "totalEarnings" value
        else if( Input.GetKeyDown( "r" ) )
        {
            totalEarnings = 0;
        }

        decimal earningsFinal = (decimal) earningsPerDay;
        earningsPerDayDisplay.text = "" + Math.Round( earningsFinal, 2 );

        decimal tipFinal = (decimal) tip;
        tipDisplay.text = "" + Math.Round( tipFinal, 2 );

        incentiveDisplay.text = "" + incentive;

        decimal dailyEarningsFinal = (decimal) dailyEarnings;
        dailyEarningsDisplay.text = "" + Math.Round( dailyEarningsFinal, 2 );

        decimal totalEarningsFinal = (decimal) totalEarnings;
        totalEarningsDisplay.text = "" + Math.Round( totalEarningsFinal, 2 );

        decimal goalAmountFinal = (decimal) goalAmount;
        goalAmountDisplay.text = "" + Math.Round( goalAmountFinal, 2 );

        dayDisplay.text = day;
    }
}