using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenager : MonoBehaviour
{
    public GameObject tabela;
    
    
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
    }
    
    public void SairDosCreditos()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
