using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogManager : MonoBehaviour
{
  public static DialogManager instance;

  public List<string> Dialogs;
  public GameObject DialogPanel;
  public TMP_Text DialogText;
  public int currentLineIndex = 0;
  public bool IsDialogOpen = false;
  private void Awake()
  {
    if (instance != null)
    {
      return;
    }
    else
    {
      instance = this;
    }
  }

  // Start is called before the first frame update
  void Start()
  {
    // Desactivar el panel de dialogo
    DialogPanel.SetActive(false);
  }

  public void StartDialog()
  {
    if (IsDialogOpen == false && currentLineIndex == 0)
    {
      // Cambiamos a true el estado del dialogo
      IsDialogOpen = true;
      // Activamos la ventana de dialogos
      DialogPanel.SetActive(true);
      // Asignamos el primer dialogo en la ventana
      DialogText.text = Dialogs[currentLineIndex];
    }
  }

  public void NextDialog()
  {
    if (IsDialogOpen == true)
    {
      // Revisamos si existen mas lineas en la lista
      if (currentLineIndex < Dialogs.Count - 1)
      {
        // Incrementamos el contador del dialogo -> currentLineIndex + 1
        currentLineIndex++;
        // Asignamos el nuevo texto a mostrar
        DialogText.text = Dialogs[currentLineIndex];
      }

      if (currentLineIndex == Dialogs.Count - 1)
      {
        EndDialog();
      }
      //else
      //{
      //  IsDialogOpen = false;
      //  // Desactivamos el panel de dialogos
      //  DialogPanel.SetActive(false);
      //}
    }
  }

  public void RestartDialogs()
  {
    currentLineIndex = 0;
    EndDialog();
  }

  public void EndDialog()
  {
    DialogPanel.SetActive(false);
    IsDialogOpen = false;
  }
}
