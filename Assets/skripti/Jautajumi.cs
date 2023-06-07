using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Jautajumi : MonoBehaviour {

    private List<string> fragmenti = new List<string> {"kādas komponentes var tikt pievienotas klāt pie GameObject?", "Kā var pakustināt GameObject?", "Kurš ir pareizs?",
     "Kas notiek kad tu izdzēsi GameObjektu no ainas?","Kurš ir pareizs par vecāku-bērnu attiecībam starp GameObjektiem?",
     "Kurš apgalvojums ir pareizs par GameObjekta aktīvo statusu?","Kurš apgalvojums ir pareizs par gameObjekta Layeru?",
     "kurš apgalvojums ir pareizs par funkciju Instantiate()?","Kurš apgalvojums ir pareizs par GameObjekta redzamību?","kāda nozīme ir collideram uzliktam uz GameObjekta?"};
    private List<string> fragmenti1 = new List<string> {"Mesh Renderer", "kustinot kameras pozīciju", "GameObjekti var būt tikai 3D",
    "GameObjekts tiek izdzēsts no hierarchy","Vecāku GameObjektiem nevar būt komponentes klāt.",
    "Neaktīvs GameObjekts tiek galīgi izņemts no ainas","Layer īpašības nosaka GameObjekta izmēru",
    "Instantiate funkcija uzstaisa kopiju no GameObject","GameObjekta redzamība ir noteikta no viņas pozīcijas","tā nosaka GameObjekta pozīciju ainā"};
    private List<string> fragmenti2 = new List<string> {"Audio Source", "mainot GameObjekta Tag", "GameObjekti ir vizuāli efekti priekš spēles",
    "GameObjekts tiek izdzēsts neatgriezeniski","Bērnu GameObjekti paņem vecāku pozīciju un rotāciju",
    "Neaktīvam gameObjektam nevar būt komponentes","Layer īpašība tiek izmantota lai pieliktu pielāgotu izskatu GameObjektam",
    "Instantiate funkcija neatgriezeniski izdzēš GameObjektu no ainas","GameObjekta redzamība var būt kontrolēta mainot viņas alpha vērtību","tā kontrolē gameObjekta redzamību"};
    private List<string> fragmenti3 = new List<string> {"Script", "Modifējot Transform komponenti", "GameObjekts ir veids kā parādīt vizuāli objektus kādā ainā",
    "GameObjekts tiek iznīcināts un izņemts no ainas","Vecāku GameObjektiem var būt tikai 1 bērns",
    "Neaktīvs GameObjekts neupdato vai izpilda scripts zem viņa","Layer īpašība tiek izmantota lai redzētu vai kautkas saskaras ar GameObjectu",
    "Instantiate funkcija tikai strādā ar 3D GameObjektiem","GameObjekta redzamība var tikt ieslēgta un izslēgta ar viņās rendered komponenti","viņa definē GameObjekta formu un robežas priekš sadursmes"};
    private List<string> fragmenti4 = new List<string> {"Light", "Mainot GameObjekta Layer", "NAV IZDOMĀTA ATBILDE VĒL",
    "GameObjekts paliek neredzams un turpina dzīvot ainā","Bērnu GameObjektus nevar saredzēt ainā",
    "pie Neaktīva GameObjekta nevar piekļūt caur koda","Layer īpašība var būt tikai uz tādiem GameObjektiem ar kuriem nevar saskarties",
    "Instantie funkcija var tikai izmantot ja nopērk specifisku Unity Pro licenzi","GameObjekta redzamību nevar manuāli mainīt un tiek regulēta automātiski","Viņa atskaņo audio kad saskaras ar citu GameObjektu"};

    private int indekss = 0;
    private int PareizasAtbildes = 0;
    private string NepareizasAtbildes = "";
 private bool Taimers = true;
    public float TaimeraStarts;
    public float TaimeraBeigas;
    public GameObject tekstaAttelosana;
    public Toggle[] AtbildesTogglePogas;
    public Button nakošaisJautajumsPoga;
    public GameObject toggle1;
    public GameObject toggle2;
    public GameObject toggle3;
    public GameObject toggle4;
    public GameObject BeiguScreen;
    public GameObject TextaLaiks;
    public GameObject CikNoCik;
    public GameObject Zvaigzne1;
    public GameObject Zvaigzne2;
    public GameObject Zvaigzne3;
    public AudioSource uzvara;
    public GameObject NepareizasAtbildesTeksts;
    public GameObject Atbildes;
   
 private void Start()
    {
        Taimers = true;
        IzvaditJautajumu();
        SaktTimer();
    }
    private void Update(){
         if (Taimers)
        {
            if (indekss < 10 && !BeiguScreen.activeSelf)
            {
                TaimeraBeigas = Time.time;
            }
            else
            {
                Taimers = false;
                BeigtTimer();
            }
        }
    }

#region VissKasIrPrieksJautajumiem
    public void UzglabatTekstu()
    {
        if (indekss < fragmenti.Count)
        {
            if (!VaiToggleIrIeslegts())
                return;

                if (indekss == 0)
        { 
            if (AtbildesTogglePogas[0].isOn)
            {
               
                Debug.Log("Pareizā atbilde tika ievadīta1");
                PareizasAtbildes++;
            }else{
                NepareizasAtbildes+="1) kādas komponentes var tikt pievienotas klāt pie GameObject?";
            }
            
        }if (indekss == 1){
            if (AtbildesTogglePogas[0].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta2");
            }else{
                NepareizasAtbildes+="\n2) Kā var pakustināt GameObject?";
            }

        }
         if (indekss == 2){
            if (AtbildesTogglePogas[3].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta3");
            }else{
                NepareizasAtbildes+="\n3) Kurš ir pareizs?";
            }

        }
         if (indekss == 3){
            if (AtbildesTogglePogas[1].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta4");
            }else{
                NepareizasAtbildes+="\n4) Kas notiek kad tu izdzēsi GameObjektu no ainas?";
            }

        }
         if (indekss == 4){/////////
            if (AtbildesTogglePogas[0].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta5");
            }else{
                NepareizasAtbildes+="\n5) Kurš ir pareizs par vecāku-bērnu attiecībam starp GameObjektiem?";
            }

        }
         if (indekss == 5){
            if (AtbildesTogglePogas[1].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta6");
            }else{
                NepareizasAtbildes+="\n6) Kurš apgalvojums ir pareizs par GameObjekta aktīvo statusu?";
            }

        }
         if (indekss == 6){
            if (AtbildesTogglePogas[1].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta7");
            }else{
                NepareizasAtbildes+="\n7) Kurš apgalvojums ir pareizs par gameObjekta Layeru?";
            }

        }
         if (indekss == 7){
            if (AtbildesTogglePogas[0].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta8");
            }else{
                NepareizasAtbildes+="\n8) kurš apgalvojums ir pareizs par funkciju Instantiate()?";
            }

        }
         if (indekss == 8){
            if (AtbildesTogglePogas[2].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta9");
            }else{
                NepareizasAtbildes+="\n9) Kurš apgalvojums ir pareizs par GameObjekta redzamību?";
            }

        }
         if (indekss == 9){
            if (AtbildesTogglePogas[3].isOn)
            {
               PareizasAtbildes++;
                Debug.Log("Pareizā atbilde tika ievadīta10");
            }else{
                NepareizasAtbildes+="\n10) kāda nozīme ir collideram uzliktam uz GameObjekta?";
            }

        }


            indekss++;
        if(indekss==10){
             BeiguScreen.SetActive(!BeiguScreen.activeSelf);
             uzvara.Play();
        }
            IzvaditJautajumu();
        }
    }

    private void IzvaditJautajumu()
    {
        if (indekss < fragmenti.Count)
        {
            tekstaAttelosana.GetComponent<Text>().text = fragmenti[indekss];
            IzvaditAtbildes();
            IzslegtTogglePogu();
        }
    }

    private void IzvaditAtbildes()
    {
        if (indekss < fragmenti.Count)
        {
            toggle1.GetComponent<Text>().text = fragmenti1[indekss];
            toggle2.GetComponent<Text>().text = fragmenti2[indekss];
            toggle3.GetComponent<Text>().text = fragmenti3[indekss];
            toggle4.GetComponent<Text>().text = fragmenti4[indekss];
        }
    }

    private void IzslegtTogglePogu()
    {
        for (int i = 0; i < AtbildesTogglePogas.Length; i++)
        {
            AtbildesTogglePogas[i].isOn = false;
        }
    }

    private bool VaiToggleIrIeslegts()
    {
        for (int i = 0; i < AtbildesTogglePogas.Length; i++)
        {
            if (AtbildesTogglePogas[i].isOn)
            {
                return true;
            }
        }
        return false;
    }
    #endregion

#region TimeraDaļa
private void SaktTimer()
    {
        TaimeraStarts = Time.time;
        Debug.Log("Timer started!");
    }

    private void BeigtTimer()
    {
        TaimeraBeigas = Time.time;
        float duration = TaimeraBeigas - TaimeraStarts;
        Debug.Log("Laiks Beidzās! Laiks: " + duration.ToString("F2") + " Sekundes");
        TextaLaiks.GetComponent<Text>().text ="Laiks: " +duration.ToString("F2") + " Sekundes";
        NepareizasAtbildesTeksts.GetComponent<Text>().text = NepareizasAtbildes;
        CikNoCik.GetComponent<Text>().text=PareizasAtbildes+"/10";
        if(PareizasAtbildes>=9f){
                Zvaigzne1.SetActive(!Zvaigzne1.activeSelf);
                Zvaigzne2.SetActive(!Zvaigzne2.activeSelf);
                Zvaigzne3.SetActive(!Zvaigzne3.activeSelf);
            }else if(PareizasAtbildes>=5f && PareizasAtbildes <=8){
                Zvaigzne1.SetActive(!Zvaigzne1.activeSelf);
                Zvaigzne2.SetActive(!Zvaigzne2.activeSelf);
            }else{
                Zvaigzne1.SetActive(!Zvaigzne1.activeSelf);
            }
    }

#endregion

public void BeiguAtbildes(){
    
    Atbildes.SetActive(!Atbildes.activeSelf);

} 

}
