namespace PINValidation
{
    public class DebitCard
    {
        private string? _pin;

        public string PIN {
            get
            {
                if(_pin is null)
                    return string.Empty;

                return _pin;
            } 
            set
            {   
                if(string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("PIN can't be blank");
                }
                else if(! int.TryParse(value ,out int tempPIN))
                {
                    System.Console.WriteLine($"PIN = {value}  -->invalid ,PIN should be digits only.");
                }
                else if((value.Length == 4) || (value.Length == 6))
                {
                    _pin = value;
                    System.Console.WriteLine($"PIN = {value}  -->valid");
                }
                else
                {
                 System.Console.WriteLine($"PIN = {value}  -->invalid ,PIN can be either 4 digits or 6 digits.");
                }

            } 
        }
    }
}