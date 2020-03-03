﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusExpense
{
    public partial class FormBus : Form
    {
        public FormBus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate the number of days of parking, and any remaining credit, 
            // for an amount of credit added to a campus card
         
            bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded); //inline variable creation
            bool costOneParkWithCardValid = Double.TryParse(txtOneParkWithCard.Text, out double costOneParkWithCard);
            bool costOneParkNoCardValid = Double.TryParse(txtOneParkNoCard.Text, out double costOneparkNoCard);

            if (creditValid && costOneParkWithCardValid && costOneParkNoCardValid)
            {
                // Calculate number of times user can park, and any remaining credit

                int daysParking = (int)(creditAdded / costOneParkWithCard);
                double creditRemaining = creditAdded % costOneParkWithCard;
                double oneDaySavings = costOneparkNoCard - costOneParkWithCard;
                double totalSavings = daysParking * oneDaySavings;

                txtDaysParking.Text = daysParking.ToString();  // Must set Text to a String
                txtCreditRemaining.Text = creditRemaining.ToString("c");  //Use currency formatting 
                txtSavings.Text = totalSavings.ToString("c");
            }
            else
            {
                MessageBox.Show("Please enter numbers", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
