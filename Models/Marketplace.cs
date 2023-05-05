using System.Text;

namespace Models;
public class Marketplace
{
    private int _listingId;
    private string _itemName;
    private int _quantity;
    private int _unitPrice;
    private int _sellerId;
    private string _url="";
    
    public Marketplace(int listingId, string itemName, int quantity, int unitPrice, string url, int sellerId)
    {
        _listingId=listingId;
        _itemName=itemName;
        _quantity=quantity;
        _unitPrice=unitPrice;
        _url=url;
        _sellerId=sellerId;
    }
    public int ListingId {
        set {
            _listingId=value;
        }
        get {
            return _listingId;
        }
    }
    public string ItemName {
        set {
            _itemName=value;
        }
        get {
            return _itemName;
        }
    }

     public string Url {
        set {
            _url=value;
        }
        get {
            return _url;
        }
    }
    public int Quantity {
        set {
            _quantity=value;
        }
        get {
            return _quantity;
        }
    }
    public int UnitPrice {
        set {
            _unitPrice=value;
        }
        get {
            return _unitPrice;
        }
    }
    public int SellerId {
        set {
            _sellerId=value;
        }
        get {
            return _sellerId;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append($"ID: {this.ListingId} | ItemName: {this.ItemName}");
        return sb.ToString();
    }
}




