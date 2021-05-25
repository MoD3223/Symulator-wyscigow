using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyscigow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Greyhound One = new Greyhound()
            {
                MyPictureBox = pictureBox2
            };

            Greyhound Two = new Greyhound()
            {
                MyPictureBox = pictureBox3
            };

            Greyhound Three = new Greyhound()
            {
                MyPictureBox = pictureBox4
            };

            Greyhound Four = new Greyhound()
            {
                MyPictureBox = pictureBox5
            };

            Guy Janek = new Guy()
            {
                Name = "Janek",
                Cash = 50,
                MyRadioButton = radioButton1
            };

            Guy Bartek = new Guy()
            {
                Name = "Bartek",
                Cash = 75,
                MyRadioButton = radioButton2
            };

            Guy Arek = new Guy()
            {
                Name = "Arek",
                Cash = 45,
                MyRadioButton = radioButton3
            };

            //Jak dodać Bet.MinimumAmount??
            minimumBetLabel.Text = "Minimalna kwota zakładu: 5zł";
        }
    }

    public class Greyhound
    {
        public int StartingPosition = 22; //Miejsce gdzie rozpoczyna się picturebox
        public int RacetrackLenght = 525; //Jak długa jest trasa
        public PictureBox MyPictureBox = null; //Mój obiekt picturebox
        public int Location = 22; //Moje położenie na torze wyścigowym
        public Random MyRandom; //Instancja klasy Random


        public bool Run()
        {
            //How to update???
            Location += MyRandom.Next(1,4);
            if (Location >= 525)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakingStartingPosition()
        {
            Location = 22;
            StartingPosition = 22;
            MyPictureBox.Location = new Point(22);
        }


    }

    public class Guy
    {
        public string Name;
        public Bet MyBet; //Instancja Klasy bet przechowująca dane o zakładzie
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabel()
        {
            //Ustaw moje pole tekstowe na opis zakładu, a napis pola wyboru tak aby pokazywał ilość pieniędzy
        }

        public void Clearbet()
        {
            if (MyBet.Amount >= MyBet.MinimumAmount)
            {
                MyBet.Bettor.Cash += MyBet.Amount;
            }
            else
            {
                MyBet.Amount = 0;
            }
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            //Ustaw nowy zakład i przechowaj go w polu MyBet
            //Zwróć true jeżeli facet ma wystarczająca ilość pieniędzy
            return true;

        }

        public void Collect(int Winner)
        {
            if (MyBet.Dog == Winner)
            {
                MyBet.Bettor.Cash += MyBet.Amount * 2;
            }
            UpdateLabel();


            //Poproś o wypłatę zakładu i zaktualizuj etykiety
        }

    }

    public class Bet
    {
        public int MinimumAmount = 5; //Minimalna ilość pieniędzy do postawienia
        public int Amount; //Ilość postawionych pieniędzy
        public int Dog; //Numer psa na którego postawiono
        public Guy Bettor; //Facet który zawarł zakład

        public string GetDescription()
        {
            if (Amount == 0)
            {
                return Bettor + " nie zawarł zakładu";
            }
            else
            {
                return Bettor + " postawił " + Amount + " na psa numer " + Dog;
            }
        }

        public int PayOut(int Winner)
        {
            //???????????
            //Take winner from run()
            return 0;
        }

    }


}
