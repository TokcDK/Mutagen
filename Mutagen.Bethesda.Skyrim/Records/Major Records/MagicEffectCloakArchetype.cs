using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.Skyrim;

public partial class MagicEffectCloakArchetype
{
    public FormLink<ISpellGetter> Association => this.AssociationKey.ToLink<ISpellGetter>();

    IFormLink<ISpellGetter> IMagicEffectCloakArchetype.Association => this.Association;
    IFormLinkGetter<ISpellGetter> IMagicEffectCloakArchetypeGetter.Association => this.Association;

    public MagicEffectCloakArchetype()
        : base(TypeEnum.Cloak)
    {
    }
}

public partial interface IMagicEffectCloakArchetype
{
    new IFormLink<ISpellGetter> Association { get; }
}

public partial interface IMagicEffectCloakArchetypeGetter
{
    IFormLinkGetter<ISpellGetter> Association { get; }
}

partial class MagicEffectCloakArchetypeBinaryOverlay
{
    public IFormLinkGetter<ISpellGetter> Association => this.AssociationKey.ToLink<ISpellGetter>();
}