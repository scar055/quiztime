using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime
{
    class QuizQuestions
    {
        private Int32 _questionId;
        private string _questionQuiz;
        private string _questionImage;
        private string _questionDate;

        public Int32 QuestionId
        {
            get { return _questionId; }
            set { _questionId = value; }
        }
        public string QuestionQuiz
        {
            get { return _questionQuiz; }
            set { _questionQuiz = value; }
        }
        public string QuestionImage
        {
            get { return _questionImage; }
            set { _questionImage = value; }
        }
        public string QuestionDate
        {
            get { return _questionDate; }
            set { _questionDate = value; }
        }

        SQL sql = new SQL();
        public DataSet getData(int quiz_id)
        {
            string SQL = $"SELECT question_id, quiz_questions, question_image, questions_date FROM quiz_questions WHERE quiz_id ={quiz_id}";

            return sql.getDataSet(SQL);
        }
        public void Create(Int32 quizId, string quizQuestions, string questionImage)
        {
            string SQL = string.Format("INSERT INTO db_quiztime.quiz_questions ( quiz_id, quiz_questions, question_image) VALUE('{0}', '{1}', '{2}')", quizId, quizQuestions, questionImage);
            sql.ExecuteNonQuery(SQL);
        }
        public void Read(Int32 questionsId)
        {
            string SQL = string.Format("SELECT question_id, quiz_questions, question_image, questions_date FROM db_quiztime.quiz_questions WHERE question_id = {0}", questionsId);
            DataTable dataTable = sql.getDataTable(SQL);
            _questionId = Convert.ToInt32(dataTable.Rows[0]["question_id"].ToString());
            _questionQuiz = dataTable.Rows[0]["quiz_questions"].ToString();
            _questionImage = dataTable.Rows[0]["question_image"].ToString();
            _questionDate = dataTable.Rows[0]["questions_date"].ToString();
        }
        public void update(Int32 questionsNr, string quizQuestions, string quizImage)
        {


            quizImage = quizImage.Replace(@"\", @"\\");
            string SQL = string.Format("UPDATE `db_quiztime`.`quiz_questions` " +
                                       "SET `quiz_questions`    = '{0}', " +
                                       "`question_image`        = '{1}' " +
                                       "WHERE `question_id`     = {2}", quizQuestions,
                                                                        quizImage,
                                                                        questionsNr);
            sql.ExecuteNonQuery(SQL);
            //System.Windows.MessageBox.Show(quizName + " is geupdate");
        }
        public bool Delete(Int32 questionsNr)
        {
            bool isDeleted = false;
            if (System.Windows.MessageBox.Show("Moet ik gegevens verwijderen?", "Question", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Warning) == System.Windows.MessageBoxResult.Yes)
            {
                string SQL = string.Format("DELETE FROM db_quiztime.quiz_questions WHERE question_id = {0};", questionsNr);
                sql.ExecuteNonQuery(SQL);
                isDeleted = true;

                System.Windows.MessageBox.Show("gegevens zijn verwijderd");
            }
            return isDeleted;
        }
    }
}
