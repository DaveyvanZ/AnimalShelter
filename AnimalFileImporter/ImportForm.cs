using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AnimalFileImporter
{
    public partial class AnimalFileImporterForm : Form
    {
           
        public AnimalFileImporterForm()
        {
            InitializeComponent();
         
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            try 
            {
                openFileDialog1.ShowDialog();
                string[] Lines1 = File.ReadAllLines(openFileDialog1.FileName);
                for (int i = 0; i < Lines1.Length; i++)
                {
                    if (Lines1[i].ToLower().Contains("cat: "))
                    {
                        string[] tempArrayCat = Lines1[i].Substring(5, Lines1[i].Length - 5).Split(',');
                        //chipnummer, naam, geboortedatum en de slechte gewoonten

                        string Cat = (tempArrayCat[0] + tempArrayCat[2] + tempArrayCat[1] + tempArrayCat[5]);
                        lbCat.Items.Add(Cat);
                    }
                    else
                    {
                        string[] tempArrayDog = Lines1[i].Substring(5, Lines1[i].Length - 5).Split(',');
                        string Dog = (tempArrayDog[0] + tempArrayDog[2] + tempArrayDog[1]);
                        lbDog.Items.Add(Dog);
                    }
                }
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            } 
            catch (ArgumentNullException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (PathTooLongException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (FileLoadException exception)
            {
                MessageBox.Show(exception.Message);
            }   
            catch(UnauthorizedAccessException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (IndexOutOfRangeException exception)
           {
                MessageBox.Show(exception.Message);
                MessageBox.Show("Please choose a valid file type, if you choose an invalid file type, the program cant read the file (in for humans readable characters)");
           }
        }
      }
    }

