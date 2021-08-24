using System;
using System.Web.UI.WebControls;

namespace WebFormularKalender
{
    public partial class _default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //evaluate Checkbox State
                if (sundayFirst.Checked)
                {
                    kalender.FirstDayOfWeek = FirstDayOfWeek.Sunday;
                }
                else
                {
                    kalender.FirstDayOfWeek = FirstDayOfWeek.Default;
                }
            }
        }

        protected void kalender_SelectionChanged(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = kalender.SelectedDate;
            ausgabe.Text = dt.ToShortDateString();
        }

        protected void tuesdayFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (tuesdayFirst.Checked)
            {
                kalender.FirstDayOfWeek = FirstDayOfWeek.Tuesday;
            }
            else
            {
                kalender.FirstDayOfWeek = FirstDayOfWeek.Default;
            }
            tuesdayFirst.Checked = !tuesdayFirst.Checked;
        }

        protected void saturdayFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (saturdayFirst.Checked)
            {
                kalender.FirstDayOfWeek = FirstDayOfWeek.Saturday;
            }
            else
            {
                kalender.FirstDayOfWeek = FirstDayOfWeek.Default;
            }
        }
    }
}