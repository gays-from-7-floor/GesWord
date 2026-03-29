namespace GesWord;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    TextBox[] letterTextBoxes;
    string[] words = {"кошка", "собака", "шиншила", "бегемот", "зебра" };
    string gesWord = "";
    char[] letterWordArr = { };
    char letterPersonal;
    
private void buttonGenerateWord_Click(object sender, EventArgs e)
    {   
        Random random = new Random();
        gesWord = words[random.Next(words.Length)];
        labelWord.Text = gesWord;
        
        // Удаляем старые текстбоксы, если есть
        if (letterTextBoxes != null)
        {
            foreach (var tb in letterTextBoxes)
            {
                this.Controls.Remove(tb);
                tb.Dispose();
            }
        }
        int x = 46, y = 128;
        int textBoxSize = 20;
        int padding = 10;
        
        letterTextBoxes = new TextBox[gesWord.Length];
        letterWordArr = gesWord.ToCharArray();
        
        
        for (int i = 0; i < gesWord.Length; i++)
        {
            
            letterTextBoxes[i] = new TextBox();
            letterTextBoxes[i].Location = new Point(x,y);
            letterTextBoxes[i].Name = "letterTextBox" + i;
            letterTextBoxes[i].Size = new Size(textBoxSize, textBoxSize);
            this.Controls.Add(letterTextBoxes[i]);
            letterTextBoxes[i].Tag = i;
            letterTextBoxes[i].TextChanged += letterTextBoxes_TextChanged;
            x += textBoxSize + padding;
            
        }

        x = 15;
    }


    private void letterTextBoxes_TextChanged(object sender, EventArgs e)
    {
        TextBox currentTextBox = sender as TextBox;
        int currentIndex = (int)currentTextBox.Tag; // получаем индекс из Tag
        
        
        if (!string.IsNullOrEmpty(currentTextBox.Text))
        {
            letterPersonal = currentTextBox.Text[0];
            currentTextBox.BackColor = Color.White;
        }
 
        if (letterPersonal == letterWordArr[currentIndex])
        {
            label1.Text = "буква на месте";
            currentTextBox.BackColor = Color.Green;
        }
        else if (letterWordArr.Contains(letterPersonal))
        {
            label1.Text = "буква есть в слове";
            currentTextBox.BackColor = Color.Yellow;
        }
        else
        {
            label1.Text = "буквы нет в слове";
            currentTextBox.BackColor = Color.Red;
        }
        
    }
    
}
