class Applicatoin
{
    private GUIFactory Factory;

    public Button Button;


    public void Application(GUIFactory factory)
    {

    }

    public void CreateUI()
    {

    }

    public void Paint()
    {

    }

}
interface GUIFactory
{
    Button CreateButton();
    CheackBox CreateCheackbox();
    RadioButton CreateRadioButton();
    Textbox CreateTextBox();
    Lable CreateLable();
}
class WinFactory : GUIFactory
{
    public Button CreateButton()
    {
        Console.WriteLine("Создалась вин кнопка");
        return new WinButton();
    }

    public CheackBox CreateCheackbox()
    {
        Console.WriteLine("Создался винчекбокс");
        return new WinCheackbox();
    }

    public Lable CreateLable()
    {
        Console.WriteLine("Создался лейбл");
        return new Lable();
    }

    public RadioButton CreateRadioButton()
    {
        Console.WriteLine("Создалась радиокнопка");
        return new RadioButton();
    }

    public Textbox CreateTextBox()
    {
        Console.WriteLine("Создался текстбокс");
        return new Textbox();
    }
}
class MacFactory : GUIFactory
{
    public Button CreateButton()
    {
        Console.WriteLine("Создалась мак кнопка");
        return new MacButton();
    }

    public CheackBox CreateCheackbox()
    {
        Console.WriteLine("Создался мак чекбокс");
        return new MacCheackbox();
    }

    public Lable CreateLable()
    {
        Console.WriteLine("Создался лейбл");
        return new Lable();
    }

    public RadioButton CreateRadioButton()
    {
        Console.WriteLine("Создалась радиокнопка");
        return new RadioButton();
    }

    public Textbox CreateTextBox()
    {
        Console.WriteLine("Создался текстбокс");
        return new Textbox();
    }
}


class Button
{

}
class CheackBox
{

}

class RadioButton
{

}
class Textbox
{

}
class Lable
{

}

class WinButton : Button
{

}
class WinCheackbox : CheackBox
{

}

class MacCheackbox : CheackBox
{

}
class MacButton : Button
{

}

