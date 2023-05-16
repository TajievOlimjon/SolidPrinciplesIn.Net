namespace SRPDemo
{
    public class MobileStore
    {
        List<Phone> phones = new List<Phone>();
        public PhoneReader Reader { get; set; }
        public PhoneBinder Binder { get; set; }
        public PhoneValidator Validator { get; set; }
        public PhoneSaver Saver { get; set; }
        public MobileStore(PhoneReader reader,PhoneBinder binder,PhoneValidator validator,PhoneSaver saver)
        {
            Reader = reader;
            Binder = binder;
            Validator = validator;
            Saver = saver;
        }
        public void Process()
        {
            var result = true;
            while (result)
            {
                var phone = Reader.GetInputData();
                var phoneCreate = Binder.CreatePhone(phone);
                if (Validator.IsValid(phoneCreate))
                {
                    phones.Add(phone);
                    Saver.Save(phone, "store.txt");
                }
                else
                {
                    Console.WriteLine("Некорректные данные");
                }
                if (phone.Model == "true") result = false;
            }
        }
    }
    public class PhoneReader
    {
        public Phone GetInputData()
        {
            Console.WriteLine("Введите модель");
            string? model = Console.ReadLine();
            Console.WriteLine("Введите цену");
            int price =Convert.ToInt32(Console.ReadLine());
            return new Phone(model, price);
        }
    }
    public class PhoneBinder
    {
        public Phone CreatePhone(Phone phone)
        {
           if(phone.Model is not null && phone.Price!=0)
           {
                return phone;
           }
            throw new Exception("Ошибка привязчика модели Phone. Некорректные данные");
        }
    }
    public class PhoneValidator 
    {
        public bool IsValid(Phone phone)
        {
            var result = phone.Model != null && phone.Price > 0;
            return result;
        }
    }
    public class PhoneSaver
    {
        public void Save(Phone phone, string fileName)
        {
            Console.WriteLine("Phone successfully saved !!!");
        }
    }

}