using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    class quizAnswers
    {
        private Int32 _answersId;
        private string _answers;
        private string _rightAnswer;
        private string _answerDate;
        public Int32 AnswersId
        {
            get { return _answersId; }
            set { _answersId = value; }
        }
        public string Answers
        {
            get { return _answers; }
            set { _answers = value; }
        }
        public string RightAnswer
        {
            get { return _rightAnswer; }
            set { _rightAnswer = value; }
        }
        public string AnswerDate
        {
            get { return _answerDate; }
            set { _answerDate = value; }
        }
        SQL sql = new SQL();

        public DataSet getData(int questions_id)
        {
            string SQL = $"SELECT answers_id, answers, right_answer, answers_date FROM quiz_answers WHERE questions_id ={questions_id}";

            return sql.getDataSet(SQL);
        }
        public void Create(Int32 questions_id, string answers, string rightAnswers)
        {
            string SQL = string.Format("INSERT INTO db_quiztime.quiz_answers ( questions_id, answers, right_answer) VALUE('{0}', '{1}', '{2}')", questions_id, answers, rightAnswers);
            sql.ExecuteNonQuery(SQL);
        }
        public void Read(Int32 answersId)
        {
            string SQL = string.Format("SELECT answers_id, answers, right_answer, answers_date FROM db_quiztime.quiz_answers WHERE answers_id = {0}", answersId);
            DataTable dataTable = sql.getDataTable(SQL);
            _answersId = Convert.ToInt32(dataTable.Rows[0]["answers_id"].ToString());
            _answers = dataTable.Rows[0]["answers"].ToString();
            _rightAnswer = dataTable.Rows[0]["right_answer"].ToString();
            _answerDate = dataTable.Rows[0]["answers_date"].ToString();
        }
        public void update(Int32 answersNr, string answers, string rightAnswer)
        {
            string SQL = string.Format("UPDATE db_quiztime.quiz_answers " +
                                       "SET `answers`         = '{0}', " +
                                       "`right_answer`        = '{1}' " +
                                       "WHERE `answers_id`  =  {2}", answers,
                                                                     rightAnswer,
                                                                     answersNr);
            sql.ExecuteNonQuery(SQL);
            //System.Windows.MessageBox.Show(quizName + " is geupdate");
        }
        public bool Delete(Int32 answersNr)
        {
            bool isDeleted = false;
            if (System.Windows.MessageBox.Show("Moet ik gegevens verwijderen?", "Vraag", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Warning) == System.Windows.MessageBoxResult.Yes)
            {
                string SQL = string.Format("DELETE FROM db_quiztime.quiz_answers WHERE answers_id = {0};", answersNr);
                sql.ExecuteNonQuery(SQL);
                isDeleted = true;

                //System.Windows.MessageBox.Show("gegevens zijn verwijderd");
            }
            return isDeleted;
        }

        public bool AddDelete(Int32 QuestionId)
        {
            bool isDeleted = false;

            string SQL = string.Format("DELETE FROM db_quiztime.quiz_answers WHERE questions_id = {0};", QuestionId);
            sql.ExecuteNonQuery(SQL);
            isDeleted = true;

            return isDeleted;
        }
    }
}
