
interface IEnemy
{
  float Health { get; set; }
  public void GetDamage(float damageAmount);

  public void Shoot();
}
