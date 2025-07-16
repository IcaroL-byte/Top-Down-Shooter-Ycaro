using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenager : MonoBehaviour
{
    public GameObject tabela;
    public GameObject menu;
    public GameObject audio;
    public GameObject video;
    public GameObject controles;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tabela.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EntrandoNoJogo()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void IndoAosCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void IndoOpicoes()
    {
        tabela.SetActive(true);
        controles.SetActive(true);
        menu.SetActive(false);
        audio.SetActive(false);
        video.SetActive(false);
    }

    public void SaindoOpicoes()
    {
        tabela.SetActive(false);
        menu.SetActive(true);
    }
    
    public void SairDosCreditos()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ControlesIndo()
    {
        controles.SetActive(true);
        menu.SetActive(false);
        audio.SetActive(false);
        video.SetActive(false);
    }

    public void AudioIndo()
    {
        controles.SetActive(false);
        menu.SetActive(false);
        audio.SetActive(true);
        video.SetActive(false);
    }

    public void VideoIndo()
    {
        controles.SetActive(false);
        menu.SetActive(false);
        audio.SetActive(false);
        video.SetActive(true);
    }
}
