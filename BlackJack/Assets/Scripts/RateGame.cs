using UnityEngine;

public class RateApp : MonoBehaviour
{
    private string rateUrl = "market://details?id=�����������������������";

    public void RateApplication()
    {
        Application.OpenURL(rateUrl);
    }
}
