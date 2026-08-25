using UnityEngine;

public class ClearCounter : BaseCounter,IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact(Player player)
    {
        if (!hasKitchenObject())   //counter is empty
        {
            if (player.hasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
        }
        else if(!player.hasKitchenObject())   //counter has object but player dosent
        {
            GetKitchenObject().SetKitchenObjectParent(player);
        }
    }
}
