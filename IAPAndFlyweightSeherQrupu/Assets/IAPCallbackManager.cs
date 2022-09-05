using UnityEngine;
using UnityEngine.Purchasing;

public class IAPCallbackManager : MonoBehaviour
{
	[SerializeField] private string coins500id;

	[SerializeField] private string noAdsId;


	public void OnPurchaseCompletedSuccessfully(Product product)
	{
		if(product.definition.id == coins500id)
		{
			print("You get 500 coins");
		}
		else if(product.definition.id == noAdsId)
		{
			print("ads removed");
		}
	}

	public void OnPurchaseFailed(Product product,PurchaseFailureReason reason)
	{

		print("Cannot purchased product");
		switch (reason)
		{
			case PurchaseFailureReason.PurchasingUnavailable:
				break;
			case PurchaseFailureReason.ExistingPurchasePending:
				break;
			case PurchaseFailureReason.ProductUnavailable:
				break;
			case PurchaseFailureReason.SignatureInvalid:
				break;
			case PurchaseFailureReason.UserCancelled:
				break;
			case PurchaseFailureReason.PaymentDeclined:
				break;
			case PurchaseFailureReason.DuplicateTransaction:
				break;
			case PurchaseFailureReason.Unknown:
				break;
			default:
				break;
		}

	}
}
