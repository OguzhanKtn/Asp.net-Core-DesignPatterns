using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context;

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name +" "+ appUser.Surname,
                Magazine = "Science",
                Content = "The july issue of our science magazine will be delivered to you on July 1. The topics will be the planet Jupiter and Mars."
            });
            context.SaveChanges();
        }
    }
}
