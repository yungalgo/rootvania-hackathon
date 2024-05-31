using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;

namespace Thirdweb.Examples
{
    public class NewScript2 : MonoBehaviour
    {
        ThirdwebSDK sdk;
        private Contract contract;
        private string wallet;
        public int balancePublic;

        public GameObject nftHolder;
        public GameObject nftHolderSuccess;

        public Prefab_NFT preFabNFT;

        public AudioClip mintSuccess;
        public Button closeButton;

        private void Start()
        {
            sdk = ThirdwebManager.Instance.SDK;
            wallet = PlayerPrefs.GetString("Address");
            //  checkBalance();
        }



        public async void GetNftMedia()
        {
            contract = sdk.GetContract("0x46Cc0E83bC5C3Fa19D85c62088149A7E976f3c4b");
            NFT nft = await contract.ERC1155.Get("0");
            Prefab_NFT preFabNFTScript = preFabNFT.GetComponent<Prefab_NFT>();
            preFabNFTScript.LoadNFT(nft);
        }

        public async void ClaimNFT()
        {
            contract = sdk.GetContract("0x46Cc0E83bC5C3Fa19D85c62088149A7E976f3c4b");
            var data = await contract.ERC1155.Claim("0", 1);
            //if (data.receipt.confirmations.IsOne)
            //{
            //    nftHolderSuccess.transform.GetChild(0).GetChild(4).GetComponent<TextMeshProUGUI>().text = "Failed";
            //    print("Fail");
            //}
            //else
            //{
            //    GetComponent<AudioSource>().PlayOneShot(mintSuccess);
            //    nftHolderSuccess.transform.GetChild(0).GetChild(4).GetComponent<TextMeshProUGUI>().text = "Success";
            //    print("Success");
            //}
        }

        //public async void checkBalance()
        //{
        //    string address = await sdk.Wallet.GetAddress();
        //    Contract contract = sdk.GetContract("0x46Cc0E83bC5C3Fa19D85c62088149A7E976f3c4b");
        //    var balance = await contract.ERC1155.BalanceOf(address, "0");
        //    //balancePublic = int.Parse(balance);
        //    //print(balance + " **");
        //}
    }
}


