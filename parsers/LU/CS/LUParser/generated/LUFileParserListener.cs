//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\LUFileParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="LUFileParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface ILUFileParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] LUFileParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] LUFileParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.paragraph"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParagraph([NotNull] LUFileParser.ParagraphContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.paragraph"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParagraph([NotNull] LUFileParser.ParagraphContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewline([NotNull] LUFileParser.NewlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewline([NotNull] LUFileParser.NewlineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.errorString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorString([NotNull] LUFileParser.ErrorStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.errorString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorString([NotNull] LUFileParser.ErrorStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.nestedIntentSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedIntentSection([NotNull] LUFileParser.NestedIntentSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.nestedIntentSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedIntentSection([NotNull] LUFileParser.NestedIntentSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.nestedIntentNameLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedIntentNameLine([NotNull] LUFileParser.NestedIntentNameLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.nestedIntentNameLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedIntentNameLine([NotNull] LUFileParser.NestedIntentNameLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.nestedIntentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedIntentName([NotNull] LUFileParser.NestedIntentNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.nestedIntentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedIntentName([NotNull] LUFileParser.NestedIntentNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.nameIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameIdentifier([NotNull] LUFileParser.NameIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.nameIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameIdentifier([NotNull] LUFileParser.NameIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.nestedIntentBodyDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedIntentBodyDefinition([NotNull] LUFileParser.NestedIntentBodyDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.nestedIntentBodyDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedIntentBodyDefinition([NotNull] LUFileParser.NestedIntentBodyDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.subIntentDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubIntentDefinition([NotNull] LUFileParser.SubIntentDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.subIntentDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubIntentDefinition([NotNull] LUFileParser.SubIntentDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.simpleIntentSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleIntentSection([NotNull] LUFileParser.SimpleIntentSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.simpleIntentSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleIntentSection([NotNull] LUFileParser.SimpleIntentSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.intentDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntentDefinition([NotNull] LUFileParser.IntentDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.intentDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntentDefinition([NotNull] LUFileParser.IntentDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.intentNameLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntentNameLine([NotNull] LUFileParser.IntentNameLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.intentNameLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntentNameLine([NotNull] LUFileParser.IntentNameLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.intentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntentName([NotNull] LUFileParser.IntentNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.intentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntentName([NotNull] LUFileParser.IntentNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.intentBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntentBody([NotNull] LUFileParser.IntentBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.intentBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntentBody([NotNull] LUFileParser.IntentBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.normalIntentBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalIntentBody([NotNull] LUFileParser.NormalIntentBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.normalIntentBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalIntentBody([NotNull] LUFileParser.NormalIntentBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.normalIntentString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalIntentString([NotNull] LUFileParser.NormalIntentStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.normalIntentString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalIntentString([NotNull] LUFileParser.NormalIntentStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntitySection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntitySection([NotNull] LUFileParser.NewEntitySectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntitySection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntitySection([NotNull] LUFileParser.NewEntitySectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityDefinition([NotNull] LUFileParser.NewEntityDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityDefinition([NotNull] LUFileParser.NewEntityDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityListbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityListbody([NotNull] LUFileParser.NewEntityListbodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityListbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityListbody([NotNull] LUFileParser.NewEntityListbodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityLine([NotNull] LUFileParser.NewEntityLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityLine([NotNull] LUFileParser.NewEntityLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newCompositeDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewCompositeDefinition([NotNull] LUFileParser.NewCompositeDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newCompositeDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewCompositeDefinition([NotNull] LUFileParser.NewCompositeDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newRegexDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewRegexDefinition([NotNull] LUFileParser.NewRegexDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newRegexDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewRegexDefinition([NotNull] LUFileParser.NewRegexDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityType([NotNull] LUFileParser.NewEntityTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityType([NotNull] LUFileParser.NewEntityTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityRoles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityRoles([NotNull] LUFileParser.NewEntityRolesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityRoles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityRoles([NotNull] LUFileParser.NewEntityRolesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityUsesFeatures"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityUsesFeatures([NotNull] LUFileParser.NewEntityUsesFeaturesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityUsesFeatures"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityUsesFeatures([NotNull] LUFileParser.NewEntityUsesFeaturesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityRoleOrFeatures"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityRoleOrFeatures([NotNull] LUFileParser.NewEntityRoleOrFeaturesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityRoleOrFeatures"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityRoleOrFeatures([NotNull] LUFileParser.NewEntityRoleOrFeaturesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityName([NotNull] LUFileParser.NewEntityNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityName([NotNull] LUFileParser.NewEntityNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.newEntityNameWithWS"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewEntityNameWithWS([NotNull] LUFileParser.NewEntityNameWithWSContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.newEntityNameWithWS"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewEntityNameWithWS([NotNull] LUFileParser.NewEntityNameWithWSContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.entitySection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntitySection([NotNull] LUFileParser.EntitySectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.entitySection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntitySection([NotNull] LUFileParser.EntitySectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.entityDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntityDefinition([NotNull] LUFileParser.EntityDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.entityDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntityDefinition([NotNull] LUFileParser.EntityDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.entityLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntityLine([NotNull] LUFileParser.EntityLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.entityLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntityLine([NotNull] LUFileParser.EntityLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.entityName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntityName([NotNull] LUFileParser.EntityNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.entityName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntityName([NotNull] LUFileParser.EntityNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.entityType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntityType([NotNull] LUFileParser.EntityTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.entityType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntityType([NotNull] LUFileParser.EntityTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.compositeEntityIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompositeEntityIdentifier([NotNull] LUFileParser.CompositeEntityIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.compositeEntityIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompositeEntityIdentifier([NotNull] LUFileParser.CompositeEntityIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.regexEntityIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegexEntityIdentifier([NotNull] LUFileParser.RegexEntityIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.regexEntityIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegexEntityIdentifier([NotNull] LUFileParser.RegexEntityIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.entityListBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntityListBody([NotNull] LUFileParser.EntityListBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.entityListBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntityListBody([NotNull] LUFileParser.EntityListBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.normalItemString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalItemString([NotNull] LUFileParser.NormalItemStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.normalItemString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalItemString([NotNull] LUFileParser.NormalItemStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.importSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportSection([NotNull] LUFileParser.ImportSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.importSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportSection([NotNull] LUFileParser.ImportSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.importDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportDefinition([NotNull] LUFileParser.ImportDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.importDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportDefinition([NotNull] LUFileParser.ImportDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.qnaSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQnaSection([NotNull] LUFileParser.QnaSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.qnaSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQnaSection([NotNull] LUFileParser.QnaSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.qnaDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQnaDefinition([NotNull] LUFileParser.QnaDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.qnaDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQnaDefinition([NotNull] LUFileParser.QnaDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.qnaSourceInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQnaSourceInfo([NotNull] LUFileParser.QnaSourceInfoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.qnaSourceInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQnaSourceInfo([NotNull] LUFileParser.QnaSourceInfoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.qnaIdMark"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQnaIdMark([NotNull] LUFileParser.QnaIdMarkContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.qnaIdMark"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQnaIdMark([NotNull] LUFileParser.QnaIdMarkContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.qnaQuestion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQnaQuestion([NotNull] LUFileParser.QnaQuestionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.qnaQuestion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQnaQuestion([NotNull] LUFileParser.QnaQuestionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.questionText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuestionText([NotNull] LUFileParser.QuestionTextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.questionText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuestionText([NotNull] LUFileParser.QuestionTextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.moreQuestionsBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoreQuestionsBody([NotNull] LUFileParser.MoreQuestionsBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.moreQuestionsBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoreQuestionsBody([NotNull] LUFileParser.MoreQuestionsBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.moreQuestion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoreQuestion([NotNull] LUFileParser.MoreQuestionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.moreQuestion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoreQuestion([NotNull] LUFileParser.MoreQuestionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.errorQuestionString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorQuestionString([NotNull] LUFileParser.ErrorQuestionStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.errorQuestionString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorQuestionString([NotNull] LUFileParser.ErrorQuestionStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.qnaAnswerBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQnaAnswerBody([NotNull] LUFileParser.QnaAnswerBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.qnaAnswerBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQnaAnswerBody([NotNull] LUFileParser.QnaAnswerBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.filterSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterSection([NotNull] LUFileParser.FilterSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.filterSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterSection([NotNull] LUFileParser.FilterSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.promptSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPromptSection([NotNull] LUFileParser.PromptSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.promptSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPromptSection([NotNull] LUFileParser.PromptSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.filterLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterLine([NotNull] LUFileParser.FilterLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.filterLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterLine([NotNull] LUFileParser.FilterLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.errorFilterLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterErrorFilterLine([NotNull] LUFileParser.ErrorFilterLineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.errorFilterLine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitErrorFilterLine([NotNull] LUFileParser.ErrorFilterLineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.multiLineAnswer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiLineAnswer([NotNull] LUFileParser.MultiLineAnswerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.multiLineAnswer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiLineAnswer([NotNull] LUFileParser.MultiLineAnswerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.modelInfoSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModelInfoSection([NotNull] LUFileParser.ModelInfoSectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.modelInfoSection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModelInfoSection([NotNull] LUFileParser.ModelInfoSectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="LUFileParser.modelInfoDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModelInfoDefinition([NotNull] LUFileParser.ModelInfoDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="LUFileParser.modelInfoDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModelInfoDefinition([NotNull] LUFileParser.ModelInfoDefinitionContext context);
}