using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    class Quiz
    {
        private Int32 _quizId;
        private string _quizName;
        private string _quizDate;

        public Int32 quizId
        {
            get { return _quizId; }
            set { _quizId = value; }
        }
        public string quizName
        {
            get { return _quizName; }
            set { _quizName = value; }
        }
        public string quizDate
        {
            get { return _quizDate; }
            set { _quizDate = value; }
        }

        SQL sql = new SQL();

        public DataSet getData()
        {
            string SQL = "SELECT quiz_id, quiz_name, quiz_date FROM quiz";
            return sql.getDataSet(SQL);
        }
        public void Create(string quizName)
        {
            string SQL = string.Format("INSERT INTO db_quiztime.quiz (quiz_name) VALUE('{0}')", quizName);
            sql.ExecuteNonQuery(SQL);
        }
        public void Read(Int32 quizId)
        {
            string SQL = string.Format("SELECT quiz_id, quiz_name, quiz_date FROM db_quiztime.quiz WHERE quiz_id = {0}", quizId);
            DataTable dataTable = sql.getDataTable(SQL);
            _quizId = Convert.ToInt32(dataTable.Rows[0]["quiz_id"].ToString());
            _quizName = dataTable.Rows[0]["quiz_name"].ToString();
            _quizDate = dataTable.Rows[0]["quiz_date"].ToString();
        }
        public void update(Int32 quizId, string quizName)
        {
            string SQL = string.Format("UPDATE db_quiztime.quiz " +
                                       "SET quiz_name    = '{0}' " +
                                       "WHERE quiz_id    =  {1}", quizName,
                                                                  quizId);
            sql.ExecuteNonQuery(SQL);
            //System.Windows.MessageBox.Show(quizName + " is geupdate");
        }
        public bool Delete(Int32 quizNr)
        {
            bool isDeleted = false;
            if (System.Windows.MessageBox.Show("Moet ik gegevens verwijderen?", "Question", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Warning) == System.Windows.MessageBoxResult.Yes)
            {
                string SQL = string.Format("DELETE FROM db_quiztime.quiz WHERE quiz_id = {0};", quizNr);
                sql.ExecuteNonQuery(SQL);
                isDeleted = true;

                System.Windows.MessageBox.Show("gegevens zijn verwijderd");
            }
            return isDeleted;
        }
    }
}
