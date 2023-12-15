using UnityEngine;

[CreateAssetMenu(fileName = "PolygonIDConfig", menuName = "PolygonID/Config", order = 1)]
public class PolygonIDConfig : ScriptableObject
{
    [Header("Polygon ID Configurations")]
    public string blockchain = "polygon";
    public string network = "mumbai";
    public string web3Url = "https://polygon-mumbai.infura.io/v3/";
    public string web3RdpUrl = "wss://polygon-mumbai.infura.io/v3/";
    public string web3ApiKey = "theApiKey";
    public string idStateContract = "0x134B1BE34911E39A8397ec6289782989729807a4";
    public string pushUrl = "https://push-staging.polygonid.com/api/v1";
}
