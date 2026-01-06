using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceJourney
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXTName.Clear();
            TXTPhone.Clear();
            TXTSnils.Clear();
            radioButtonRus.Checked=false;
            radioButtonCarpet.Checked=false;
            radioButtonMusk.Checked=false;
            radioButtonUFO.Checked=false;
            labelSomeText.Text = "Введенные параметры сброшены";
            
        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {//в поле ввода имени теперь можно ввести только буквы и дефисы, а главное - без использования ИИ!
           foreach (char TXT in TXTName.Text)
            {if (char.IsDigit(TXT) == true || char.IsPunctuation(TXT) == true|| TXT==' ')
                { if (TXT=='-') { continue; } 
                        TXTName.Clear();
                        labelSomeText.Text = "В имя вводим буквы,\n не числа и знаки препинания.\n Заново теперь!  ";
                    
                }
            
            }

        }

        private void TXTPhone_TextChanged(object sender, EventArgs e)
        {//конечно же метод linq который проверяет условие и кстати выполняется мгновенно
            if (TXTPhone.Text.Any(x=>char.IsPunctuation((char)x)||char.IsLetter((char)x)||(char)x=='+' || (char)x == '№' || (char)x == '=' || (char)x == ' ') ==true|| string.IsNullOrWhiteSpace(TXTPhone.Text)) //метод ispunctuation не предусмотрел этих символов
            { 
                TXTPhone.Clear();
                labelSomeText.Text = "В номер вводим цифры,\n не буквы и знаки препинания.\n Да! Все предусмотрено!\nПлюс не нужен! ";
            }
        }

        private void TXTSnils_TextChanged(object sender, EventArgs e)
        {
            if (TXTSnils.Text.Any(x => char.IsPunctuation((char)x) || char.IsLetter((char)x) || (char)x == '+' || (char)x == '№' || (char)x == '=' || (char)x == ' ') == true) //метод ispunctuation не предусмотрел этих символов
            {
                TXTSnils.Clear();
                labelSomeText.Text = "В СНИЛС вводим цифры,\n не буквы и знаки препинания.   ";
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            if (AllEntered() == false) { labelSomeText.Text = "Заполните все поля\n или никуда не полетите."; return; }

            else if(  IsRepeating(TXTName.Text, TXTPhone.Text, TXTSnils.Text, RBValue(), CHPlanetValue())          )
            {
                labelSomeText.Text = "НЕТ! Нельзя повторяться."; return ;
            }

            else
            {
                Order order= new Order(TXTName.Text, TXTPhone.Text, TXTSnils.Text, RBValue(), CHPlanetValue());

                labelSomeText.Text = "Ок, данные занесены!";

                dataGridOrders.Rows.Add(order.Name, order.Phone, order.Snils, order.RType, order.ChosenPlanet); //наглядно: в таблицу теперь передаются данные из класса честно это не иишные комменты это мои заметки
            }
        }

        private bool IsRepeating(string name, string phone, string snils, string select, string selPlanet)
        {//можно юыло проверять пустая ли строка, но если добавление через кнопку, то если пренебречь, ничего не потеряем
            foreach (DataGridViewRow row in dataGridOrders.Rows)
            {  //без вопростельного знака выскакивала ошибка ссылка на экземпляр не указывает на обьект. ? это нулевой оператор короче проверка на ноль короче работает не трогай
                
                string inputedName = row.Cells["ColumnName"].Value?.ToString();
                string inputedPhone = row.Cells["ColumnPhone"].Value?.ToString();
                string inputedSnils = row.Cells["ColumnSnils"].Value?.ToString();
                string inputedRBT= row.Cells["ColumnRocket"].Value?.ToString();
                string inputedPlanet = row.Cells["ColumnPlanet"].Value?.ToString();
                if(name==inputedName && phone==inputedPhone && snils==inputedSnils&&  select==inputedRBT&&selPlanet==inputedPlanet) { return true; }
                

            }
            return false;
        }

        private string CHPlanetValue()
        {
            return comboBoxPlanets?.SelectedItem?.ToString();
            
        }


        //ну просто значение передает
        private string RBValue()
        {
            string select = "";
            if (radioButtonCarpet.Checked) select = "Ковёр";
            else if (radioButtonMusk.Checked) select = "SPACEX";
            else if (radioButtonRus.Checked) select = "Ракета наша";
            else if (radioButtonUFO.Checked) select = "НЛО";
            return select;
        }
        //проверяю все ли поля заполнены и в отдельном методе могу сколь угодно уродливый код делать. приватный потому что помимо этой формы нигде не будет применяться
        private bool AllEntered( )
        {

            bool planetSelected = comboBoxPlanets.SelectedItem != null;

            if (!planetSelected)
            {
                 return false;
            }
            if (string.IsNullOrEmpty(comboBoxPlanets.SelectedItem.ToString())) return false;
            if (string.IsNullOrWhiteSpace(TXTName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(TXTPhone.Text))  //вот так и решилась проблема что если занести данные в таюлицу а потом удалить иъ с текстбокса можно занести пустые строки 
                return false;

            if (string.IsNullOrWhiteSpace(TXTSnils.Text)) //метод строки провеяет ну короче понятно что
                return false;
            
            bool rbtChecked = radioButtonCarpet.Checked ||
                            radioButtonMusk.Checked ||
                            radioButtonRus.Checked ||
                            radioButtonUFO.Checked;
            if (!rbtChecked) { return false; }

            return true;
        }

        private void buttonEraseFromGrid_Click(object sender, EventArgs e)
        {//все очень просто в плане того что даже не возникнет проблемы что пользователь захочет отдельно кусок колонки в строке удалить ибо ЗАЧЕМ 
            //плюс чтобы за раз не сносил всю таюлицу 
            if(dataGridOrders.SelectedRows.Count ==1)

            {
                dataGridOrders.Rows.Remove(dataGridOrders.SelectedRows[0]);
            }
            else
            {
                labelSomeText.Text = "За раз удалить можно \nтолько одну строку.\n Кликаем левый столбец! ";
            }
        }
    }
}
