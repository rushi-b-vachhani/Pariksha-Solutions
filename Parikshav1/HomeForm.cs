using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parikshav1.pojo;
namespace Parikshav1
{
    public partial class HomeForm : Form
    {
        List<Exam> vExamList = null;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            pExamListBody.Visible = true;
            pHead.Visible = true;
            pFooter.Visible = true;
            vExamList = Exam.getExams();
            examlistbody_lvExamList.Items.Clear();
            foreach (var exam in vExamList)
            {
                var row = new String[] { exam.Code, exam.Name, exam.Description };
                var listViewItem = new ListViewItem(row);
                listViewItem.Tag = exam;
                examlistbody_lvExamList.Items.Add(listViewItem);

            }
        }

        private void examlistbody_lvExamList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var optedExam = (Exam)examlistbody_lvExamList.SelectedItems[0].Tag;
                if (optedExam != null)
                {
                    MessageBox.Show(optedExam.Name, "Exam details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
