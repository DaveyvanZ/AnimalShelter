using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;


namespace AnimalShelter
{
        [Serializable]
    public partial class AdministrationForm : Form
    {

        private Administration administration;
        private int number;
        private string badHabits;
        private SaveFileDialog saveFile = new SaveFileDialog();

        private SimpleDate now = new SimpleDate(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);


        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            cbAnimalType.SelectedIndex = 0;
            cbAnimal.DisplayMember = "ChipRegistrationNumber";
            administration = new Administration();
            StartAnimal();
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {

           
                SimpleDate birthday = new SimpleDate(dtBirth.Value.Day, dtBirth.Value.Month, dtBirth.Value.Year);
                SimpleDate walked = new SimpleDate(DateWalked.Value.Day, DateWalked.Value.Month, DateWalked.Value.Year);
            
 
            if (tbName.Text != null && tbName.Text != "")
            {
            if (int.TryParse(tbChip.Text, out number))
            {
                try
                {

                    AddAnAnimal(birthday, walked);

                }
                catch (BornInFutureException borninfuture)
                {
                    MessageBox.Show(borninfuture.Message);
                }
                catch (WalkBeforeBornException walk)
                {
                    MessageBox.Show(walk.Message);
                }
                catch (IndexOutOfRangeException index)
                {
                    MessageBox.Show(index.Message);
                }

            }
            else
            {
                MessageBox.Show("Please fill in a legit Chipregistrationnumber, whitch is positive");
            }
        }

    else
        {
            MessageBox.Show("Please fill in a name");
        }
    }



    private void AddAnAnimal(SimpleDate birthday, SimpleDate walked)
        {

            if (cbAnimalType.Text == "Dog")
            {

                    Dog dog = new Dog(number, birthday, tbName.Text, walked, tbPhoto.Text);
                    AddAnimal(dog);
                    UpdateGUI();
            }

            if (cbAnimalType.Text == "Cat")
            {
                Cat cat = new Cat(number, birthday, tbName.Text, tbBadHabits.Text, tbPhoto.Text);
                if (tbBadHabits.Text == "")
                {
                    badHabits = Microsoft.VisualBasic.Interaction.InputBox
                        ("Are you sure your cat does't have bad habits? If it have bad habbits, you can fill it in here",
                            "Title", "", -1, -1);
                    cat.BadHabits = badHabits;
                    AddAnimal(cat);
                }
                AddAnimal(cat);
            }
        }


        private void cbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnimalType.Text == "Dog")
            {
                DateWalked.Enabled = true;
                tbBadHabits.Enabled = false;
            }
            if (cbAnimalType.Text == "Cat")
            {
                tbBadHabits.Enabled = true;
                DateWalked.Enabled = false;
            }
        }

        /// <summary>
        /// this method clears the GUI, en adds the animal to the listbox
        /// </summary>
        private void UpdateGUI()
        {
            tbBadHabits.Text = null;
            tbChip.Text = null;
            tbName.Text = null;

            administration.Animals.Sort();
            pbAnimal.Image = null;
            listReserved.Items.Clear();
            listUnReserved.Items.Clear();
            cbAnimal.Items.Clear();
            foreach (Animal animal in administration.Animals)
            {
                cbAnimal.Items.Add(animal);

                if (!animal.IsReserved)
                {
                    listUnReserved.Items.Add(animal);
                }
                else
                {
                    listReserved.Items.Add(animal);
                }
            }



        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>

        private void btShowInfo_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            try
                //  if (cbAnimal.SelectedItem != null)
            {
                Animal animal = cbAnimal.SelectedItem as Animal;
                MessageBox.Show((Convert.ToString(animal)));
                if (cbAnimal.SelectedItem is Cat)
                {
                    Cat tempcat = (cbAnimal.SelectedItem) as Cat;
                    badHabits = Microsoft.VisualBasic.Interaction.InputBox
                        ("If your cat get a bad habbit, you can fill it in here",
                            "BadHabits", "", -1, -1);
                    tempcat.BadHabits = badHabits;
                }

            }


            catch (ArgumentNullException nullexc)
            {
                MessageBox.Show(nullexc.Message);
            }


        }

        private void btRemove_Click(object sender, EventArgs e)
        {

            if (cbAnimal.SelectedItem != null)
            {
                DeleteAnimal(cbAnimal.SelectedItem as Animal);
            }

            else
            {
                MessageBox.Show("Please choose an animal");
            }
        }


        private void btReserve_Click(object sender, EventArgs e)
        {
            if (cbAnimal.SelectedItem != null)
            {
                Animal animal = cbAnimal.SelectedItem as Animal;

                if (animal.IsReserved)
                {
                    MessageBox.Show("The animal is already reserved.");
                }
                else
                {
                    animal.IsReserved = true;
                    listUnReserved.Items.Remove(animal);
                    listReserved.Items.Add(animal);
                    UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("Please choose an animal");
            }
        }

        private void btUnreserveAnimal_Click(object sender, EventArgs e)
        {
            if (cbAnimal.SelectedItem != null)
            {
                Animal animal = cbAnimal.SelectedItem as Animal;

                if (!animal.IsReserved)
                {
                    MessageBox.Show("The animal is already unreserved.");
                }
                else
                {
                    animal.IsReserved = false;
                    listReserved.Items.Remove(animal);
                    listUnReserved.Items.Add(animal);
                    UpdateGUI();
                }
            }
            else
            {
                MessageBox.Show("Please choose an animal");
            }
        }

        /// <summary>
        /// this method creates 3 animals, with a random date of birth and last date walked
        /// </summary>
        private void StartAnimal()
        {
            Random random = new Random();
            SimpleDate simpleDate = new SimpleDate(random.Next(1, 28), random.Next(1, 12), random.Next(1990, 1999));
            SimpleDate simpleDate2 = new SimpleDate(random.Next(1, 28), random.Next(1, 12), random.Next(1999, 2005));
            SimpleDate simpleDate3 = new SimpleDate(random.Next(1, 28), random.Next(1, 12), random.Next(2005, 2014));
  
            Cat cat = new Cat(random.Next(0, 20000), simpleDate2, "Dave", "", "");
            AddAnimal(cat);
            Dog dog = new Dog(random.Next(0, 20000), simpleDate, "Geisha", simpleDate2, "");
            AddAnimal(dog);
            Cat cat2 = new Cat(random.Next(0, 20000), simpleDate3, "Smokey", "Scratching", "");
            AddAnimal(cat2);

        }

        /// <summary>
        /// adds an animal to the checkbox and to the list, also updates the GUI
        /// </summary>
        /// <param name="animal"></param>
        private void AddAnimal(Animal animal)
        {

            if (administration.Add(animal))
            {

                cbAnimal.Items.Add(animal);
                listUnReserved.Items.Add(animal);
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("can't add animal");
                // nu zou dit niet nodig zijn, omdat alle elementen in het AdministrationForm worden afgevangen.
                //Als je alleen de methode in de klasse administraion zou gebruiken zou het wel nodig zijn.
            }
        }

        private void DeleteAnimal(Animal animal)
        {
            if (administration.RemoveAnimal(animal.ChipRegistrationNumber))
            {
                administration.RemoveAnimal(animal.ChipRegistrationNumber);
                listUnReserved.Items.Remove(cbAnimal.SelectedItem);
                listReserved.Items.Remove(cbAnimal.SelectedItem);
                cbAnimal.Items.Remove(cbAnimal.SelectedItem);
                UpdateGUI();
            }
        }



        private void btBrowsePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // image file path
                tbPhoto.Text = open.FileName;
            }
        }

        private void cbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

            Animal animal = cbAnimal.SelectedItem as Animal;
            if (animal.Photo != "")
            {
                pbAnimal.Image = new Bitmap(animal.Photo);
                pbAnimal.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (animal.Photo == "")
            {
                pbAnimal.Image = Image.FromFile("Photo/nopicavailable.png");
                pbAnimal.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string pathOfsaveFile = saveFile.FileName;
                    administration.Save(pathOfsaveFile);
                }
            }
            catch (ArgumentNullException arnull)
            {
                MessageBox.Show(arnull.Message);
            }
            catch (PathTooLongException pathlong)
            {
                MessageBox.Show(pathlong.Message);
            }
            catch (ArgumentException argument)
            {
                MessageBox.Show(argument.Message);
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string pathOfOpenFile = openFile.FileName;
                    administration.Load(pathOfOpenFile);
                    UpdateGUI();
                }
            }
            catch (ArgumentNullException arnull)
            {
                MessageBox.Show(arnull.Message);
            }
            catch (PathTooLongException pathlong)
            {
                MessageBox.Show(pathlong.Message);
            }
            catch (FileNotFoundException notfound)
            {
                MessageBox.Show(notfound.Message);
            }
            catch (ArgumentException argument)
            {
                MessageBox.Show(argument.Message);
            }
            catch (SerializationException serialize)
            {
                MessageBox.Show(serialize.Message);
            }
            catch (NullReferenceException refrence)
            {
                MessageBox.Show(refrence.Message);
            }

        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    administration.Export(saveFile.FileName);
                }
            }
            catch (ArgumentNullException arnull)
            {
                MessageBox.Show(arnull.Message);
            }
            catch (ArgumentException argument)
            {
                MessageBox.Show(argument.Message);
            }
            catch (PathTooLongException pathlong)
            {
                MessageBox.Show(pathlong.Message);
            }
            catch (FileNotFoundException notfound)
            {
                MessageBox.Show(notfound.Message);
            }
            catch (ObjectDisposedException objectdis)
            {
                MessageBox.Show(objectdis.Message);
            }
        }





    }
}
