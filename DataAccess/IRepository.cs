using Models;

namespace DataAccess;
public interface IRepository{
        List<User> GetAllUsers();
        List<Item> GetAllItems();
        User AddUser(User user);
        User GetUserByID(int userID);
        User GetUserByUsername(string username);
        bool UserLogin(User user);
        User ViewPersonalInventory(User user);
        void sellItem(Sellinfo sellinfo);
        void buyItem(Misc misc);
        List<Marketplace> GetMarketplaceItems();

        List<Marketplace> getMarketplaceItemsByName(string searchitem);
        
        string buy_rand(int buyer_id);
}