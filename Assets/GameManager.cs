using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject window;
    public TextMeshProUGUI header;
    public TextMeshProUGUI body;
    public TextMeshProUGUI govTxt;
    public TextMeshProUGUI peopleTxt;
    public TextMeshProUGUI articleName;
    public TextMeshProUGUI govrep;
    public TextMeshProUGUI peeprep; 
    public GameObject endPanel;
    public TextMeshProUGUI endMessage;
    public int gRep = 50;
    public int pubRep = 50;
    public int storyNum = 1;
    
    private string t1 = "Government announces lower taxes for corporates";

    private string t1b =
        "The Supreme Leader declared 45% tax cuts for big businesses and increased taxation on entrepreneurs and the middle/lower income groups.";

    private string t2 = "Government to forgive debt of Gen Lightings Inc";

    private string t2b =
        "The Supreme Leader withdraws 1 billion dollars from the treasury to pay Gen Lighting Inc debt. The CEO is the Supreme Leader's brother which has raised speculations of foul play.";

    private string t3 = "A bubble bursting?";

    private string t3b =
        "Gen Lighting Inc has witnessed 200X growth since the Supreme Leader ascended the Premiership. Maybe now the bubble is bursting as Gen Lighting shares hit the lowest after allegations of fraud.";

    private string dir1 =
        "Government Directive\n\nThe government stringently objects to your defamatory and seditious report. We demand that you not publish this report since the Supreme Leader’s proclamation is pro-business and will develop our National Economy. Be a loyal citizen\n\n";

    private string dir11 = "Rebel Chit\n\nThe Harbingers of Light believe in our manifesto that light is synonymous  to the truth. We believe that you must publish the report no matter what. Towards the light of freedom!\n";

    private string dir2 =
        "Government Directive\n\nThe government demands that this report is not published because it is highly defamatory. The Supreme Leader and Gen Lighting Inc have no illegal connections. It is all perfectly ethical and right. Be a loyal citizen!\n\n";

    string dir22 = "Rebel Chit\n\nSplendid reporting it is time to let the light in and expose the Supreme Leader’s corruption. Join the Movement!\n";
    
    private string dir3 =
        "Government directive\n\nThe government demands that this report is not published because it is highly malicious. If released the resulting investor panic will destroy Gen Lighting and destabilize the government. Be a loyal citizen!\n\nRebel Chit\n\nThis is just the push we need to overthrow this dictatorship and collapse corrupt gen lighting. Come join the movement!\n";
    
    string dir33 = "Rebel Chit\n\nSplendid reporting it is time to let the light in and expose the Supreme Leader’s corruption. Join the Movement!\n";

    private string end1 = "Your publications' furious articles have defeated the supreme leader’s tyranny and light has prevailed. The government has collapsed and the rebels are scrambling to form their own force. Gen Lighting has completely collapsed.";

    private string end2 =
        "Your loyalty to the government has not gone unnoticed, the rebels have been defeated and Gen Lightings is to secure their largest profits ever. The government seems stronger than ever. The publication has been paid discreetly a million dollars. Though you wonder was that the price to sell out the light and the truth. ";
    
    private string ep1 = "EPISODE 1: TUTORIAL  ";
    private string ep2 = "EPISODE 2: UNEASY MURMURINGS ";
    private string ep3 = "EPISODE 3: THE END IS NIGH";
    
    // Start is called before the first frame update
    void Start()
    {
        endPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SetText();
        govrep.text = "Government goodwill: " + gRep + "%";
        peeprep.text = "People's trust: " + pubRep + "%";

        if (gRep >= 100)
        {
            gRep = 100;
        }

        if (pubRep >= 100)
        {
            pubRep = 100;
        }

        if (gRep <= 0)
        {
            endPanel.SetActive(true);
            endMessage.text = "Government distrusts you far too much according to anti-libel laws so you are shut down\n";
        }

        if (pubRep < 0)
        {
            endPanel.SetActive(true);
            endMessage.text =
                "People distrusts you far too much no one buys your papers";
        }

        if (gRep > pubRep && storyNum >= 3)
        {
            endPanel.SetActive(true);
            endMessage.text = "Your loyalty to the government has not gone unnoticed, the rebels have been defeated and Gen Lightings is to secure their largest profits ever. The government seems stronger than ever. The publication has been paid discreetly a million dollars. Though you wonder was that the price to sell out the light and the truth. ";
        }

        if (pubRep > gRep && storyNum >= 3)
        {
            endPanel.SetActive(true);
            endMessage.text = "Your publications' furious articles have defeated the supreme leader’s tyranny and light has prevailed. The government has collapsed and the rebels are scrambling to form their own force. Gen Lighting has completely collapsed.";
        }
    }

    public void StoryNumInc()
    {
        storyNum++;
    }

    
    
    public void SetText()
    {
        if (storyNum == 1)
        {
            header.text = t1;
            body.text = t1b;
            govTxt.text = dir1;
            peopleTxt.text = dir11;
            articleName.text = ep1;
        } else if (storyNum == 2)
        {
            header.text = t2;
            body.text = t2b;
            govTxt.text = dir2;
            peopleTxt.text = dir22;
            articleName.text = ep2;
        } else if (storyNum == 3)
        {
            header.text = t3;
            body.text = t3b;    
            govTxt.text = dir3;
            peopleTxt.text = dir33;
            articleName.text = ep3;
        }
    }
}
