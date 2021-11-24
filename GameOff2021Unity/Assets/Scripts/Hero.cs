using DG.Tweening;
using UnityEngine;

public class Hero : Combatant
{
  [SerializeField] private int heroId;
  [SerializeField] private float spotlightDistance;

  public int HeroId => heroId;
  private Command submittedCommand;

  public void SubmitCommand(Command command)
  {
    submittedCommand = command;
  }

  public Command GetSubmittedCommand()
  {
    if (submittedCommand != null) return submittedCommand;

    Debug.LogError(
      $"Failed to get submitted command of hero {Name}. Submitted command is null! (Did you call SubmitCommand?)");
    return null;
  }

  public void ResetCommand()
  {
    submittedCommand = null;
  }

  public void Spotlight()
  {
    transform.DOMoveX(transform.position.x + spotlightDistance, travelTime);
  }

  public void EndHurtAnimation()
  {
    gameObject.GetComponent<Animator>().SetBool("Hurt", false);
  }
}
