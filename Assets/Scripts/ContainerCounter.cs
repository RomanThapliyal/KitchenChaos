using System;
using UnityEngine;

public class ContainerCounter : BaseCounter,IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public event EventHandler onPlayerGrabbedObject;
    public override void Interact(Player player)
    {
        if (!player.hasKitchenObject())   //player dosent have anything
        {
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab);
            kitchenObjectTransform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
            onPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
    }
}
