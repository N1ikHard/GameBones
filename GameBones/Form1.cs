using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBones
{
    public delegate void DelegateDice(); 
    public partial class Form1 : Form
    {
        Dice dice;
        DelegateDice delegateDice;
        public Form1()
        {
            InitializeComponent();
            delegateDice = new DelegateDice(ShowDices);         //Создаем объект делегата , в конструктор сразу добавляем
            delegateDice += ShowImage;                          //один из методов для дальнейшего вызова , в дальнейшем
            delegateDice += ShowSum;                            //добавляем еще два метода
        }
        //Метод , для инициализации новых значений кубиков объекта
        private void Initilisation()                            
        {
            dice = new Dice();
        }
        //Метод , для отображения картинок кубиков
        private void ShowImage()
        {
            try               //Попытка загрузить изображения 
            {                 //Реализация патерна switch
                pictureBox1.Image = dice.GetFirst switch
                {
                    1 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetFirst.ToString() + ".jpg"),
                    2 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetFirst.ToString() + ".jpg"),
                    3 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetFirst.ToString() + ".jpg"),
                    4 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetFirst.ToString() + ".jpg"),
                    5 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetFirst.ToString() + ".jpg"),
                    6 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetFirst.ToString() + ".jpg"),
                    _ => null
                };
                pictureBox2.Image = dice.GetSecond switch
                {
                    1 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetSecond.ToString() + ".jpg"),
                    2 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetSecond.ToString() + ".jpg"),
                    3 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetSecond.ToString() + ".jpg"),
                    4 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetSecond.ToString() + ".jpg"),
                    5 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetSecond.ToString() + ".jpg"),
                    6 => Image.FromFile("D:\\Project C#\\GameBones\\GameBones\\bin\\Debug\\net5.0-windows\\image\\" + dice.GetSecond.ToString() + ".jpg"),
                    _ => null
                };
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить картинки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Метод , отображающий сумму
        private void ShowSum()
        {
            int sum = dice.GetFirst + dice.GetSecond;
            textBoxSumDices.Text = "Сумма: " + sum;
        }
        //Метод , отображающий очки на гранях
        private void ShowDices()
        {
            labelDice1.Text = dice.GetFirst.ToString();
            labelDice2.Text = dice.GetSecond.ToString();
        }
        //События при нажатаии на кнопку
        private void buttonRoll_Click(object sender, EventArgs e)
        {
            Initilisation();
            delegateDice();
        }
    }
}
