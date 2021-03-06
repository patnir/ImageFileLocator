﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

public partial class frmMain : Form
{
    private List<string> fileNames = new List<string>();
    
    private bool isBMPChecked;
    private bool isGIFChecked;
    private bool isJPGChecked;
    private bool isPNGChecked;
    private bool isTIFFChecked;
    
    private bool isFileNameOnlyChecked;

    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    public frmMain()
    {
        InitializeComponent();

        txtDirectoryToSearch.Text = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnLocateFiles_Click(object sender, EventArgs e)
    {
        lstDisplayFiles.Items.Clear();

        string directoryName = txtDirectoryToSearch.Text;

        isBMPChecked  = cbxBMP.Checked;
        isGIFChecked = cbxGIF.Checked;
        isJPGChecked = cbxJPG.Checked;
        isPNGChecked = cbxPNG.Checked;
        isTIFFChecked = cbxTIFF.Checked;

        isFileNameOnlyChecked = cbxFileNameOnly.Checked;

        if (Directory.Exists(directoryName) == false) 
        {
            MessageBox.Show("Directory does not exist.", 
                Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        searchFilesAndPrint(directoryName);

    }

    private void searchFilesAndPrint(string directoryName)
    {
        if (isBMPChecked == true)
        {
            displayFilesInDirectory(directoryName, "*.bmp");
        }
        if (isGIFChecked == true)
        {
            displayFilesInDirectory(directoryName, "*.gif");
        }
        if (isJPGChecked == true)
        {
            displayFilesInDirectory(directoryName, "*.jpg");
        }
        if (isPNGChecked == true)
        {
            displayFilesInDirectory(directoryName, "*.png");
        }
        if (isTIFFChecked == true)
        {
            displayFilesInDirectory(directoryName, "*.tiff");
        }
        try
        {
            foreach (string subFoldername in Directory.GetDirectories(directoryName))
            {
                searchFilesAndPrint(subFoldername);
            }
        }
        catch
        {
            return;
        }
    }

    private void displayFilesInDirectory(string directoryName, string extension) 
    {
        if (isFileNameOnlyChecked == true)
        {
            try
            {
                foreach (string fileName in Directory.GetFiles(directoryName, extension))
                {
                    lstDisplayFiles.Items.Add(fileName.Remove(0, directoryName.Length + 1));
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        else
        {
            try
            {
                foreach (string fileName in Directory.GetFiles(directoryName, extension))
                {
                    lstDisplayFiles.Items.Add(fileName);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}