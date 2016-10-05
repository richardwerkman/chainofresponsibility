using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsibility
{
    public partial class Form1 : Form
    {
        private Lottery Lottery { get; set; }

        public static LotteryHandler h5 = new NothingHandler(null);
        public static LotteryHandler h4 = new LettersHandler(h5);
        public static LotteryHandler h3 = new LastNumberHandler(h4);
        public static LotteryHandler h2 = new NumbersHandler(h3);
        public static LotteryHandler h1 = new JackpotHandler(h2);
        
        public Form1(Lottery Lottery)
        {
            this.Lottery = Lottery;
            InitializeComponent();
            LettersInput.MaxLength = 2;
            NumbersInput.MaxLength = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket CheckTicket = new Ticket(LettersInput.Text, NumbersInput.Text);
                string Notification = h1.handleRequest(CheckTicket, Lottery);
                NotifyLabel.Text = Notification;
            } catch(FormatException)
            {
                NotifyLabel.Text = "Invalid input";
            }
            
        }
    }
}
