using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU.RefereeAssistant.WinDesktop
{
    public partial class MatchControl : UserControl
    {
        public MatchControl()
        {
            InitializeComponent();
        }
        public string FirstPlayer {
            get
            {
                return lblFirst.Text;
            }
            set
            {
                lblFirst.Text = value;
            }
        }
        public string SecondPlayer
        {
            get
            {
                return lblSecond.Text;
            }
            set
            {
                lblSecond.Text = value;
            }
        }
        public decimal FirstScore
        {
            get
            {
                return numFirst.Value;
            }
            set
            {
                numFirst.Value = value;
            }
        }
        public decimal SecondScore
        {
            get
            {
                return numSecond.Value;
            }
            set
            {
                numSecond.Value = value;
            }
        }
    }
}
