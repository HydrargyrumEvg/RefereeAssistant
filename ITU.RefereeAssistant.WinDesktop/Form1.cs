using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.Domain.TourType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITU.RefereeAssistant.WinDesktop
{
    public partial class FormReferee : Form
    {
        private IList<string> PlayerNames { get; set; }
        public FormReferee()
        {
            InitializeComponent();
            PlayerNames = new List<string>();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer();
        }

        private void AddPlayer()
        {
            PlayerNames.Add(tbPlayerName.Text);

            var height = 20;
            var step = gbPlayer.Controls.Count;
            var label = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(7, (height * step) + 27),
                Name = "label1",
                Size = new System.Drawing.Size(78, 13),
                TabIndex = 3,
                Text = tbPlayerName.Text,
                BackColor = Color.White,
            };
            tbPlayerName.Text = "";
            this.gbPlayer.Controls.Add(label);
        }

        private void tbPlayerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPlayer();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var ts = new TournamentService();
            var ratings = PlayerNames.Select(
                name => new Rating(new Player() { Name = name })
                );
            var tour = ts.Create(ratings.ToArray(), new OlympicTourType());
            var round = ts.GenerateRound(tour);
            /*label1.Text = "";
            foreach (var match in round.Matches)
            {
                label1.Text += $"{match}\r\n";
            }*/
        }
    }
}
