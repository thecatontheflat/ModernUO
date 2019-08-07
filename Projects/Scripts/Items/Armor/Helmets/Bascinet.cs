namespace Server.Items
{
  public class Bascinet : BaseArmor
  {
    [Constructible]
    public Bascinet() : base(0x140C)
    {
      Weight = 5.0;
    }

    public Bascinet(Serial serial) : base(serial)
    {
    }

    public override int BasePhysicalResistance => 7;
    public override int BaseFireResistance => 2;
    public override int BaseColdResistance => 2;
    public override int BasePoisonResistance => 2;
    public override int BaseEnergyResistance => 2;

    public override int InitMinHits => 40;
    public override int InitMaxHits => 50;

    public override int AosStrReq => 40;
    public override int OldStrReq => 10;

    public override int ArmorBase => 18;

    public override ArmorMaterialType MaterialType => ArmorMaterialType.Plate;

    public override void Serialize(GenericWriter writer)
    {
      base.Serialize(writer);
      writer.Write(0);
    }

    public override void Deserialize(GenericReader reader)
    {
      base.Deserialize(reader);
      int version = reader.ReadInt();

      if (Weight == 1.0)
        Weight = 5.0;
    }
  }
}