using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        int testScore;
        int x;


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 20;



        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);




            if (buttonTag == correctAnswer)
            {
                score++;
                x = x + 2;


            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                testScore = (2 +(4*x)/40);

                MessageBox.Show("КРАЙ НА ТЕСТА!" + Environment.NewLine +
                                "Вие сте оговорили на " + score + " въпроса правилно!" + Environment.NewLine +
                                "Процентът на успеваемост е " + percentage + " %" + Environment.NewLine +
                                "Вашата оценка е " + testScore + Environment.NewLine +
                                "Натиски ОК, за да пробваш отново!"

                    );;

                score = 0;
                questionNumber = 0;
                testScore = 0;
                x = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);



        }

        private void askQuestion(int qnum)
        {

            

            switch(qnum)
            {

                case 1:

                    lblQuestion.Text = "Какво представлява ООП?";

                    button1.Text = "Обектно ориентирано програмиране";
                    button2.Text = "Основна офисна практика";
                    button3.Text = "Операционна система";
                    button4.Text = "Общ отворен проект";

                    correctAnswer = 1;

                    break;
                case 2:

                    lblQuestion.Text = "Какво е клас в ООП?";

                    button1.Text = "Число с плаваща запетая";
                    button2.Text = "Функция за изчисление";
                    button3.Text = "Графичен интерфейс";
                    button4.Text = "Структура която определя общи брой характеристики на обекти";

                    correctAnswer = 4;

                    break;

                case 3:

                    lblQuestion.Text = "Как се създава клас в ООП?";

                    button1.Text = "Чрез оператора +";
                    button2.Text = "Чрез деклариране на променлива";
                    button3.Text = "Чрез извикване на конструктор на класа";
                    button4.Text = "Чрез изтриване на данни";

                    correctAnswer = 3;

                    break;

                case 4:

                    lblQuestion.Text = "Каква е целта на наследяването в ООП?";

                    button1.Text = "Да се наруши инкапсулизацията";
                    button2.Text = "Да се създаде нов клас";
                    button3.Text = "Да се спестяват усилия при програмирането";
                    button4.Text = "Да се споделят характеристики и методи между класове";

                    correctAnswer = 4;

                    break;

                case 5:

                    lblQuestion.Text = "Каква е инкапсуализацията в ООП?";

                    button1.Text = "Процес на преобразуване на данни в обекти";
                    button2.Text = "Скриване на детайлите на реализацията и предоставяне на публичен интерфекс";
                    button3.Text = "Изчислителна операция";
                    button4.Text = "Създаване на нов клас";

                    correctAnswer = 2;

                    break;

                case 6:

                    lblQuestion.Text = "Каква е разликата между абстрактен клас и интерфейс в ООП?";

                    button1.Text = "Абстрактният клас няма методи, а интерфейсът има";
                    button2.Text = "Абстрактният клас не може да бъде наследяван, а интерфейсът може";
                    button3.Text = "Абстрактният клас може да има реализация на методи, а интерйесът само дефинира мотоди";
                    button4.Text = "Няма разлика, те са едно и също";

                    correctAnswer = 3;

                    break;

                case 7:

                    lblQuestion.Text = "Как се извика метод на обект в ООП?";

                    button1.Text = "С използването на оператора +";
                    button2.Text = "С използването на ключова дума METHOD";
                    button3.Text = "Чрез обкетна точка - object.method()";
                    button4.Text = "С ключовата дума - call";

                    correctAnswer = 3;

                    break;

                case 8:

                    lblQuestion.Text = "Какво представлява инкаптуализацията в ООП?";

                    button1.Text = "Съхранения на данни и методи в обект";
                    button2.Text = "Скриване на данни и методи и предоставяне на интерфейсза достъп";
                    button3.Text = "Създаване на обекти в ООП";
                    button4.Text = "Неизвестен термин в ООП";

                    correctAnswer = 2;

                    break;

                case 9:

                    lblQuestion.Text = "Какво представяла полиморфизма в ООП?";

                    button1.Text = "Възможността на обектите от различни класове да имат различни методи";
                    button2.Text = "Възможността на обектите от разклични класове да имат еднакви методи";
                    button3.Text = "Променлива с плаваща запетая";
                    button4.Text = "Създаване на нов клас";

                    correctAnswer = 2;

                    break;

                case 10:

                    
                    lblQuestion.Text = "Каква е основната цел на инкапитуализацията?";

                    button1.Text = "Да се ограничи достъпът до данни и методи на обекта";
                    button2.Text = "Да се увеличи сложността на програмта";
                    button3.Text = "Да се добавя нови дани към обекта";
                    button4.Text = "Да се премахнат методите от класа";

                    correctAnswer = 1;

                    break;

                case 11:

                    lblQuestion.Text = "Какво е наследяването в ООП?";

                    button1.Text = "Процес на създаването на нови обекти";
                    button2.Text = "Процес на споделяне на характеристики и методи между класове";
                    button3.Text = "Процес на преобразуване на данни";
                    button4.Text = "Процес на добавяне на методи към клас";

                    correctAnswer = 2;

                    break;

                case 12:

                   
                    lblQuestion.Text = "Какво е абстрактен клас в ООП?";

                    button1.Text = "Клас, от който не могат да бъдат създадени обекти";
                    button2.Text = "Клас със статични методи";
                    button3.Text = "Клас, който не съдържа данни";
                    button4.Text = "Клас със сложна реализация";

                    correctAnswer = 1;

                    break;

                case 13:

                    
                    lblQuestion.Text = "Каква е ролята на конструкторите в ООП?";

                    button1.Text = "Конструкторите определят характеристиките на обкетите";
                    button2.Text = "Конструкторите изискват методите на обектите";
                    button3.Text = "Конструкторите създават нови класове";
                    button4.Text = "Конструкторите са излишни в ООП";

                    correctAnswer = 1;

                    break;

                case 14:

                    
                    lblQuestion.Text = "Как се нарича процесът, при който клас приема характеристиките и методите на друг въпрос?";

                    button1.Text = "Наследяване";
                    button2.Text = "Полиморфизъм";
                    button3.Text = "Инкапсуализация";
                    button4.Text = "Абстракция";

                    correctAnswer = 1;

                    break;

                case 15:

                   
                    lblQuestion.Text = "Какво е агрегация в ООП?";

                    button1.Text = "Процес на създаване на нови обекти";
                    button2.Text = "Включване на един обект в друг като част от него";
                    button3.Text = "Процес на преобразуване на данни";
                    button4.Text = "Процес на наследяване на методи";

                    correctAnswer = 2;

                    break;

                case 16:

                    
                    lblQuestion.Text = "Как се нарича принципът в ООП, при който обекти от различните касове могат да се използват по един и същ начин?";

                    button1.Text = "Полиморфизъм";
                    button2.Text = "Инкапсулация";
                    button3.Text = "Наследяване";
                    button4.Text = "Абстракция";

                    correctAnswer = 1;

                    break;

                case 17:

                    
                    lblQuestion.Text = "Каква е основната цел на ООП?";

                    button1.Text = "Да се напишат максимално кратки програми";
                    button2.Text = "Да се създадат обекти";
                    button3.Text = "Да се организира програмен код по начин, който отразява реалния свят";
                    button4.Text = "Да се използват структурни от данни";

                    correctAnswer = 3;

                    break;

                case 18:

                    lblQuestion.Text = "Каква е основната цен на абстракцита на ООП?";

                    button1.Text = "Да се скрият детайлите на реализация и да се предостави интерфес за използване на обекта";
                    button2.Text = "Да се добавят допълнителни методи към класа";
                    button3.Text = "Да се опимизират програмите";
                    button4.Text = "Да се преобразуват";

                    correctAnswer = 1;

                    break;

                case 19:

                    lblQuestion.Text = "Какво преставлява композицията в ООП?";

                    button1.Text = "Процес на наследяване на методи от друг клас";
                    button2.Text = "Включване на обекти в друг клас като част от него";
                    button3.Text = "Процес на създаване на нови обекти";
                    button4.Text = "Процес на добавяне на методи към класа";

                    correctAnswer = 2;

                    break;

                case 20:

                    
                    lblQuestion.Text = "Какво е интерфейсът в ООП?";

                    button1.Text = "Списък с методи, който клас трябва да имплементира";
                    button2.Text = "Описание на обекти";
                    button3.Text = "Процес на инкапсулация";
                    button4.Text = "Включване на обекти в друг клас";

                    correctAnswer = 1;

                    break;



            }




        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
