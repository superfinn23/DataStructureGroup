using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructuresGroup
{
    public partial class frmMain : Form
    {
        int iMenu = 0; //initialize 
        int iCount = 0; //for dictionary
        Stack<string> sMyStack = new Stack<string>(); //creating a stack
        Stack<string> sTempStack = new Stack<string>(); //temp stack 
        Queue<string> qMyQueue = new Queue<string>(); //creating a queue
        Queue<string> qTempQueue = new Queue<string>(); //temp queue
        Dictionary<string, int> dMyDictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase); //creating dictionary
        bool bCheck = false;


        public frmMain()
        {
            InitializeComponent();
            lstMenuOptions.Visible = false; // set everything not visible so that they don't see the options
            lblLabel.Visible = false;
            txtBoxUser.Visible = false;
            btnEnter.Visible = false;
            lstbxDisplay.Visible = false;
            lblDelete.Visible = false;
            txtboxDelete.Visible = false;
            btnDelete.Visible = false;
            lblDisplay.Visible = false;
            btnSearch.Visible = false;
            txtboxSearch.Visible = false;
            lblSearch.Visible = false;
            lblStopwatch.Visible = false;

        }
        private void stackToolStripMenuItem_Click(object sender, EventArgs e) //if they click stack, this will happen
        {
            lstMenuOptions.Items.Clear();  // clear the list of past things
            lstMenuOptions.Items.Add("1.Add one time to Stack");  //showing for stack
            lstMenuOptions.Items.Add("2. Add Huge List of Items to Stack");
            lstMenuOptions.Items.Add("3. Display Stack");
            lstMenuOptions.Items.Add("4. Delete from Stack");
            lstMenuOptions.Items.Add("5. Clear Stack");
            lstMenuOptions.Items.Add("6. Search Stack");
            lstMenuOptions.Items.Add("7. Return to Main Menu");

            lstMenuOptions.Visible = true; // show the list box

            iMenu = 1; //setting as 1, so we can call it later
        }

        private void queueToolStripMenuItem_Click(object sender, EventArgs e) // if they click queue, this will happen
        {
            lstMenuOptions.Items.Clear(); // clear the list of past things
            lstMenuOptions.Items.Add("1.Add one time to Queue"); //show for queue
            lstMenuOptions.Items.Add("2. Add Huge List of Items to Queue");
            lstMenuOptions.Items.Add("3. Display Queue");
            lstMenuOptions.Items.Add("4. Delete from Queue");
            lstMenuOptions.Items.Add("5. Clear Queue");
            lstMenuOptions.Items.Add("6. Search Queue");
            lstMenuOptions.Items.Add("7. Return to Main Menu");

            lstMenuOptions.Visible = true; // show the list box

            iMenu = 2; //setting for queue
        }

        private void dictionaryToolStripMenuItem_Click(object sender, EventArgs e) // if they click dictionary, this will happen
        {
            lstMenuOptions.Items.Clear(); // clear the list of past things
            lstMenuOptions.Items.Add("1.Add one time to Dictionay"); //show for dicitonary
            lstMenuOptions.Items.Add("2. Add Huge List of Items to Dictionary");
            lstMenuOptions.Items.Add("3. Display Dictionary");
            lstMenuOptions.Items.Add("4. Delete from Dictionary");
            lstMenuOptions.Items.Add("5. Clear Dictionary");
            lstMenuOptions.Items.Add("6. Search Dictionary");
            lstMenuOptions.Items.Add("7. Return to Main Menu");

            lstMenuOptions.Visible = true; // show the list box

            iMenu = 3;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // if exit button is selected, we are out of here
        }

        private void lstMenuOptions_SelectedIndexChanged_1(object sender, EventArgs e)
        {

//-----------------Option 1 - Add one item -------------------------//   
            if (lstMenuOptions.SelectedIndex == 0)
            {
                lblLabel.Visible = true; //set everything visible
                txtBoxUser.Visible = true;
                txtBoxUser.Focus(); //focus on text box
                btnEnter.Visible = true;
                lblDelete.Visible = false;
                txtboxDelete.Visible = false;
                btnDelete.Visible = false;
                lblStopwatch.Visible = false;
                txtboxSearch.Visible = false;
                lblSearch.Visible = false;
                lblStopwatch.Visible = false;

                //CHECK ENTER BUTTON FOR MORE
            }
//-----------------Option 2 - Add Huge List -------------------------//
            else if (lstMenuOptions.SelectedIndex == 1)
            {
                if (iMenu == 1) //determining it is a stack
                {
                    lblLabel.Visible = false; //hide everything else so nothing bad can happen
                    txtBoxUser.Visible = false;
                    btnEnter.Visible = false;
                    lstbxDisplay.Visible = false;
                    lblDelete.Visible = false;
                    txtboxDelete.Visible = false;
                    btnDelete.Visible = false;
                    lblStopwatch.Visible = false;
                    lstbxDisplay.Items.Clear(); //clear the list so the new things can display
                    txtboxSearch.Visible = false;
                    lblSearch.Visible = false;
                    lblStopwatch.Visible = false;


                    sMyStack.Clear(); //clear out the queue
                    int iCount2 = 1; //for the entries
                    for (int iCount1 = 0; iCount1 < 2000; iCount1++) //for loop to add the new entries
                    {
                        // a counter so we know the entries
                        sMyStack.Push("New Entry " + iCount2); //add to the queue
                        iCount2++;
                    }

                }

                else if (iMenu == 2) //determining it is a queue
                {
                    qMyQueue.Clear(); //clear out the queue
                    int iCount2 = 1; //for the entries
                    for (int iCount1 = 0; iCount1 < 2000; iCount1++)//for loop to add the new entries
                    {
                        // a counter so we know the entries
                        qMyQueue.Enqueue("New Entry " + iCount2); //add to the queue
                        iCount2++; //increment
                    }

                }
                else //for the dictionary
                {

                    dMyDictionary.Clear(); //clear out the dictionary
                    int iCount2 = 1; //for the entries

                    for (int iCount1 = 0; iCount1 < 2000; iCount1++)//for loop to add the new entries
                    {

                        dMyDictionary.Add("New Entry " + iCount2, iCount2); //add to the dictionary
                        iCount2++;
                    }
                }
            }
//-----------------Option 3- Display -------------------------//
            else if (lstMenuOptions.SelectedIndex == 2)
            {
                txtBoxUser.Visible = false;
                lblLabel.Visible = false;
                btnEnter.Visible = false;
                lblDelete.Visible = false;
                txtboxDelete.Visible = false;
                btnDelete.Visible = false;
                lstbxDisplay.Visible = true; //set label box visible so the user can see it
                lblStopwatch.Visible = false;
                lstbxDisplay.Items.Clear();

                if (iMenu == 1) //if stack is selected
                {
                    foreach (string item in sMyStack) //for each loop to display everything within the stack
                    {

                        lstbxDisplay.Items.Add(item);
                    }
                }

                else if (iMenu == 2) // if queue is selected
                {
                    foreach (string item in qMyQueue) //for each loop to display everything within the queue
                    {

                        lstbxDisplay.Items.Add(item);
                    }
                }

                else // if dictionary
                {
                    foreach (KeyValuePair<string, int> item in dMyDictionary)
                    {

                        lstbxDisplay.Items.Add(item);
                    }
                }
            }
//-----------------Option 4 - Delete From -------------------------//
            else if (lstMenuOptions.SelectedIndex == 3) //option 4 - Delete from 
            {
                lblDelete.Visible = true;
                txtboxDelete.Visible = true;
                btnDelete.Visible = true;
                lblDisplay.Visible = false;
                lblStopwatch.Visible = false;
            }

            //CHECK DELETE BUTTON FOR MORE
//-----------------Option 5 - Clear -------------------------//
            else if (lstMenuOptions.SelectedIndex == 4)

            {
                //hiding everything else that doesn't matter
                txtBoxUser.Visible = false;
                btnEnter.Visible = false;
                lblDelete.Visible = false;
                txtboxDelete.Visible = false;
                btnDelete.Visible = false;
                lblLabel.Visible = false;
                lblStopwatch.Visible = false;

                lstbxDisplay.Items.Clear(); //clearing out the list

                if (iMenu == 1) //determining it is a stack
                {
                    sMyStack.Clear(); //clear out the queue
                }

                else if (iMenu == 2) //determining it is a queue
                {
                    qMyQueue.Clear(); //clear out the queue
                }


                else //for the dictionary
                {

                    dMyDictionary.Clear(); //clear out the dictionary


                }
                lstbxDisplay.Visible = true; //to prove that it has been cleared
            }
//-----------------Option 6 - Search -------------------------//
            else if (lstMenuOptions.SelectedIndex == 5)
            {
                lblSearch.Visible = true;
                btnSearch.Visible = true;
                txtboxSearch.Visible = true;
                btnDelete.Visible = false;
                txtBoxUser.Visible = false;
                btnEnter.Visible = false;
                lblDelete.Visible = false;
                txtboxDelete.Visible = false;
                btnDelete.Visible = false;
                lblLabel.Visible = false;
              
              //CHECK SEARCH BUTTON FOR MORE
            }
//-----------------Option 7 - Return -------------------------//
            else
            {
                lstMenuOptions.Visible = false;
                txtBoxUser.Visible = false;
                btnEnter.Visible = false;
                lstbxDisplay.Visible = false;
                lblDelete.Visible = false;
                txtboxDelete.Visible = false;
                btnDelete.Visible = false;
                lblLabel.Visible = false;
                lstbxDisplay.Items.Clear();
            }
        }
//-----------------Enter Button -------------------------//
        private void btnEnter_Click(object sender, EventArgs e) //this is for #1, if they press the enter button
        {
            string sName = txtBoxUser.Text.ToLower(); //setting variable for user input

            if (iMenu == 1)
            {
                sMyStack.Push(sName); //add to the stack
            }

            else if (iMenu == 2)
            {
                qMyQueue.Enqueue(sName); // add to the queue
            }

            else
            {
                dMyDictionary.Add(sName, iCount); //add the the dictionary
                iCount++;
            }

            txtBoxUser.Clear(); //clear the text box once everything has been entered

        }
        //-----------------Click on menu-------------------------//
        private void Menu_Click(object sender, EventArgs e) //hide everything if the menu is clickeds
        {
            lstMenuOptions.Visible = false;
            txtBoxUser.Visible = false;
            btnEnter.Visible = false;
            lstbxDisplay.Visible = false;
            lblDelete.Visible = false;
            txtboxDelete.Visible = false;
            btnDelete.Visible = false;
            lblLabel.Visible = false;

        }
//-----------------Delete Button -------------------------//
        private void btnDelete_Click(object sender, EventArgs e)
        {

            string sDelete;
            sDelete = txtboxDelete.Text.ToLower();
            txtboxDelete.Clear();
            lblDelete.Visible = false;
            btnDelete.Visible = false;
            lstbxDisplay.Visible = false;
            txtboxDelete.Visible = false;


        //-----------------Checking the Stack -------------------------//
                if (iMenu == 1) 
                {

                foreach (string item in sMyStack) //searching to make sure it is there
                {
                    if (item.ToLower().Equals(sDelete)) //if found
                    {
                        bCheck = true;
                        lblDelete.Visible = false;
                        lblDisplay.Visible = false;
                    }
                }

                if (bCheck == false) //if nothing is found
                {
                    lstbxDisplay.Visible = true;
                    lblDisplay.Visible = true;
                    lblDisplay.Text = "Nothing found. Try again.";
                }

                while (sMyStack.Count > 0) //while loop to see first part
                    {
                        if (sDelete == sMyStack.Peek().ToLower())
                        {
                            sMyStack.Pop();
                        }
                        else
                        {
                            sTempStack.Push(sMyStack.Pop()); //load up in temp stack
                        }
                    }

                    while (sTempStack.Count > 0) //load back to orginal stack
                    {
                        sMyStack.Push(sTempStack.Pop());
                    }

                }

        //-----------------Checking the queue -------------------------//
                else if (iMenu == 2) 
                {

                foreach (string item in qMyQueue) //searching to make sure
                {
                    if (item.ToLower().Equals(sDelete))
                    {
                        bCheck = true;
                        lblDelete.Visible = false;
                        lblDisplay.Visible = false;
                        btnDelete.Visible = false;

                    }
                }

                if (bCheck == false) //if nothing found
                {
                    lblDisplay.Visible = true; 
                    lblDisplay.Text = "Nothing found. Try again.";
                }


                for (int iCount1 = 0; iCount1 < qMyQueue.Count; iCount1++)
                    {
                        if (sDelete == qMyQueue.Peek().ToLower())
                        {
                            qMyQueue.Dequeue();
                        }
                        else
                        {
                            qTempQueue.Enqueue(qMyQueue.Dequeue());
                        }
                    }

                while (qTempQueue.Count > 0)
                {
                    qMyQueue.Enqueue(qMyQueue.Dequeue());
                }

                }
        //-----------------Checking the Dictionary -------------------------//
                else
                {
                    for (int iCount1 = 0; iCount1 < dMyDictionary.Count; iCount1++)
                    {
                        if (dMyDictionary.ContainsKey(sDelete))
                        {
                            dMyDictionary.Remove(sDelete);
                            bCheck = true;
                            lblDisplay.Visible = false;
                    }
                    }

                }

            }
//-----------------SEARCH BUTTON-------------------------//
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            

           System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); //creating stopwatch
            string sSearch;
            sSearch = txtboxSearch.Text.ToLower();
            bool bSearch = false;
            //-----------------Stack-------------------------//
            if (iMenu == 1)
            {

                foreach (string item in sMyStack) //searching to make sure it is there
                {
                    sw.Start(); //start the time
                    if (item.ToLower().Equals(sSearch)) //if found
                    {
                        sw.Stop();
                        lblStopwatch.Text = ("Match found in" + sw.Elapsed);
                        lblStopwatch.Visible = true;
                        bSearch = true;

                    }
                }
                sw.Stop();

                if (bSearch == false)
                {
                    sw.Stop();
                    lblStopwatch.Visible = true;
                    lblStopwatch.Text = "No match found";
                }
            }
            //-----------------Queue-------------------------//
            else if (iMenu == 2)
            {
                foreach (string item in qMyQueue) //searching to make sure
                {
                    if (item.ToLower().Equals(sSearch))
                    {
                        sw.Stop();
                        lblStopwatch.Text = ("Match found in" + sw.Elapsed);
                        lblStopwatch.Visible = true;
                        bSearch = true;

                    }
                }

                if (bCheck == false) //if nothing found
                {
                    lblDisplay.Visible = true;
                    lblDisplay.Text = "Nothing found. Try again.";
                }
            }
            //-----------------Dictionary-------------------------//
            else
            {
                foreach (KeyValuePair<string, int> item in dMyDictionary)
                {
                    if (item.Key.ToLower().Equals(sSearch))
                    {
                        sw.Stop();
                        lblStopwatch.Text = ("Match found in" + sw.Elapsed);
                        lblStopwatch.Visible = true;
                        bSearch = true;
                    }
                }

                if (bCheck == false) //if nothing found
                {
                    lblDisplay.Visible = true;
                    lblDisplay.Text = "Nothing found. Try again.";
                } 
            } 
        }
    }
}

