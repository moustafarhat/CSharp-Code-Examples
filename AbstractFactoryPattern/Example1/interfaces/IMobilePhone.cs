namespace AbstractFactoryPattern.Example1.interfaces
{
    /// <summary>
    /// The 'AbstractFactory' interface.
    /// </summary>
    internal interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();

        INormalPhone GetNormalPhone();
    }
}