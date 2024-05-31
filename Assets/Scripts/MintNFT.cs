using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;

namespace Thirdweb.Examples
{
    public class MintNFT : MonoBehaviour
    {
        [SerializeField]
        private GameObject nftPanel;
        public GameObject dis;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                nftPanel.SetActive(true);
                dis.GetComponent<DisplayAndMintNFT>().GetNftMedia();
                this.gameObject.SetActive(false);
            }
        }
    }
}

