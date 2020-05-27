using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Create 2 arrays to hold 10 values each
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            // variables that can be used to determine outcomes of questions
            int samePosition = 0;
            int max = 0;
            double average = 0;
            int sum = 0;
            int numThree = 0;

            //firstZero begins at -1 so that it is not part of the index
            int firstZero = -1;

            Random randGen = new Random();

            //1. Generate random values for both pre-created arrays
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randGen.Next(0, 10);
                array2[i] = randGen.Next(0, 10);
            }

            //2. Display array 1
            array1Output.Text = String.Join("", array1);

            //3. Display array 2
            array2Output.Text = String.Join("", array2);

            //4. Display array 1 in reverse order
            Array.Reverse(array1);
            reverseOutput.Text = String.Join("", array1);
            
            //reverting array1
            Array.Reverse(array1);

            //5. Determine and display the largest value in array 1     
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
            }

            maxOutput.Text = $"{max}";

            //6.Determine and display the average of all values in array 1
            for (int i = 0; i < array1.Length; i++)
            {
                average += Convert.ToDouble(array1[i]);
            }

            average /= array1.Length;
            averageOutput.Text = $"{average}";

            //7. Determine and display the sum of all even values in array 1
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] %2 == 0)
                {
                    sum += array1[i];
                }
            }

            evenOutput.Text = $"{sum}";

            //8. Determine and display the number of 3s in array 1
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 3)
                {
                    numThree++;
                }
            }

            threeOutput.Text = $"{numThree}";

            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    samePosition++;
                }
            }

            matchOutput.Text = $"{samePosition}";

            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 0 && firstZero == -1)
                {
                    firstZero = i;
                }
            }

            if (firstZero == -1)
            {
                zeroOutput.Text = "Null";
            }
            else
            {
                zeroOutput.Text = $"{firstZero}";
            }

            //2. swap and display all values between array1 and array2
            int[] arrayTemp = new int[10];

            //swapping arrays by storing in a temporary array
            arrayTemp = array1;
            array1 = array2;
            array2 = arrayTemp;
            
            swap1Output.Text = String.Join("", array1);
            swap2Output.Text = String.Join("", array2);


        }
    }
}
