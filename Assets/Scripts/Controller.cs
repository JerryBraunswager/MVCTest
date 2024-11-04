using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private Model _model;

    public string Name => _model.Name;
    public string Price => _model.Price.ToString();
    public string DiscountPrice => _model.DiscountPrice.ToString();

    public void AddButton(Translater button)
    {
        button.ButtonClicked += ReceiveClick;
    }

    public void RemoveButton(Translater button) 
    {   
        button.ButtonClicked -= ReceiveClick;
    }

    private void ReceiveClick(Translater button)
    {
        switch (button.name) 
        {
            case "ShowPanel":
                button.GetComponent<PanelShow>().ShowPanel();
                break;

            case "Buy":
                Debug.Log("Buy");
                break;
        }
    }
}
