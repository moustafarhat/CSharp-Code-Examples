namespace AbstractFactoryPattern.Example1.interfaces
{
    /// <summary>  
    /// The 'AbstractFactory' interface.  
    /// </summary>  
    interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
