using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']"
	[Register ("org/aspectj/lang/reflect/AjType", "", "Org.Aspectj.Lang.Reflect.IAjTypeInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IAjType : global::Java.Lang.Reflect.IAnnotatedElement, global::Java.Lang.Reflect.IType {

		global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaringType' and count(parameter)=0]"
			[Register ("getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaringTypeHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Reflect.Constructor EnclosingConstructor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getEnclosingConstructor' and count(parameter)=0]"
			[Register ("getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;", "GetGetEnclosingConstructorHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Reflect.Method EnclosingMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getEnclosingMethod' and count(parameter)=0]"
			[Register ("getEnclosingMethod", "()Ljava/lang/reflect/Method;", "GetGetEnclosingMethodHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IAjType EnclosingType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getEnclosingType' and count(parameter)=0]"
			[Register ("getEnclosingType", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetEnclosingTypeHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Reflect.IType GenericSupertype {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getGenericSupertype' and count(parameter)=0]"
			[Register ("getGenericSupertype", "()Ljava/lang/reflect/Type;", "GetGetGenericSupertypeHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isArray' and count(parameter)=0]"
			[Register ("isArray", "()Z", "GetIsArrayHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsAspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isAspect' and count(parameter)=0]"
			[Register ("isAspect", "()Z", "GetIsAspectHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsEnum {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isEnum' and count(parameter)=0]"
			[Register ("isEnum", "()Z", "GetIsEnumHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsInterface {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isInterface' and count(parameter)=0]"
			[Register ("isInterface", "()Z", "GetIsInterfaceHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsLocalClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isLocalClass' and count(parameter)=0]"
			[Register ("isLocalClass", "()Z", "GetIsLocalClassHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsMemberAspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isMemberAspect' and count(parameter)=0]"
			[Register ("isMemberAspect", "()Z", "GetIsMemberAspectHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsMemberClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isMemberClass' and count(parameter)=0]"
			[Register ("isMemberClass", "()Z", "GetIsMemberClassHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsPrimitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isPrimitive' and count(parameter)=0]"
			[Register ("isPrimitive", "()Z", "GetIsPrimitiveHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		bool IsPrivileged {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isPrivileged' and count(parameter)=0]"
			[Register ("isPrivileged", "()Z", "GetIsPrivilegedHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Class JavaClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getJavaClass' and count(parameter)=0]"
			[Register ("getJavaClass", "()Ljava/lang/Class;", "GetGetJavaClassHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		int Modifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getModifiers' and count(parameter)=0]"
			[Register ("getModifiers", "()I", "GetGetModifiersHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Java.Lang.Package Package {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getPackage' and count(parameter)=0]"
			[Register ("getPackage", "()Ljava/lang/Package;", "GetGetPackageHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IPerClause PerClause {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getPerClause' and count(parameter)=0]"
			[Register ("getPerClause", "()Lorg/aspectj/lang/reflect/PerClause;", "GetGetPerClauseHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		global::Org.Aspectj.Lang.Reflect.IAjType Supertype {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getSupertype' and count(parameter)=0]"
			[Register ("getSupertype", "()Lorg/aspectj/lang/reflect/AjType;", "GetGetSupertypeHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getAdvice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAdvice", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;", "GetGetAdvice_Ljava_lang_String_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAdvice GetAdvice (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getAdvice' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AdviceKind...']]"
		[Register ("getAdvice", "([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;", "GetGetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAdvice[] GetAdvice (params global::Org.Aspectj.Lang.Reflect.AdviceKind[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getAjTypes' and count(parameter)=0]"
		[Register ("getAjTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetAjTypesHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetAjTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getConstructor' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getConstructor", "([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;", "GetGetConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Constructor GetConstructor (params global::Org.Aspectj.Lang.Reflect.IAjType[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getConstructors' and count(parameter)=0]"
		[Register ("getConstructors", "()[Ljava/lang/reflect/Constructor;", "GetGetConstructorsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Constructor[] GetConstructors ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclareAnnotations' and count(parameter)=0]"
		[Register ("getDeclareAnnotations", "()[Lorg/aspectj/lang/reflect/DeclareAnnotation;", "GetGetDeclareAnnotationsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation[] GetDeclareAnnotations ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclareErrorOrWarnings' and count(parameter)=0]"
		[Register ("getDeclareErrorOrWarnings", "()[Lorg/aspectj/lang/reflect/DeclareErrorOrWarning;", "GetGetDeclareErrorOrWarningsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning[] GetDeclareErrorOrWarnings ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclareParents' and count(parameter)=0]"
		[Register ("getDeclareParents", "()[Lorg/aspectj/lang/reflect/DeclareParents;", "GetGetDeclareParentsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IDeclareParents[] GetDeclareParents ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclarePrecedence' and count(parameter)=0]"
		[Register ("getDeclarePrecedence", "()[Lorg/aspectj/lang/reflect/DeclarePrecedence;", "GetGetDeclarePrecedenceHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence[] GetDeclarePrecedence ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclareSofts' and count(parameter)=0]"
		[Register ("getDeclareSofts", "()[Lorg/aspectj/lang/reflect/DeclareSoft;", "GetGetDeclareSoftsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IDeclareSoft[] GetDeclareSofts ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredAdvice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeclaredAdvice", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;", "GetGetDeclaredAdvice_Ljava_lang_String_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAdvice GetDeclaredAdvice (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredAdvice' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AdviceKind...']]"
		[Register ("getDeclaredAdvice", "([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;", "GetGetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAdvice[] GetDeclaredAdvice (params global::Org.Aspectj.Lang.Reflect.AdviceKind[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredAjTypes' and count(parameter)=0]"
		[Register ("getDeclaredAjTypes", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetDeclaredAjTypesHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetDeclaredAjTypes ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredConstructor' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredConstructor", "([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;", "GetGetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Constructor GetDeclaredConstructor (params global::Org.Aspectj.Lang.Reflect.IAjType[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredConstructors' and count(parameter)=0]"
		[Register ("getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;", "GetGetDeclaredConstructorsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Constructor[] GetDeclaredConstructors ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", "GetGetDeclaredField_Ljava_lang_String_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Field GetDeclaredField (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredFields' and count(parameter)=0]"
		[Register ("getDeclaredFields", "()[Ljava/lang/reflect/Field;", "GetGetDeclaredFieldsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Field[] GetDeclaredFields ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredITDConstructor' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredITDConstructor", "(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration GetDeclaredITDConstructor (global::Org.Aspectj.Lang.Reflect.IAjType p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredITDConstructors' and count(parameter)=0]"
		[Register ("getDeclaredITDConstructors", "()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetDeclaredITDConstructorsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[] GetDeclaredITDConstructors ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredITDField' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;']]"
		[Register ("getDeclaredITDField", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration GetDeclaredITDField (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredITDFields' and count(parameter)=0]"
		[Register ("getDeclaredITDFields", "()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetDeclaredITDFieldsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[] GetDeclaredITDFields ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredITDMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredITDMethod", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration GetDeclaredITDMethod (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1, params global::Org.Aspectj.Lang.Reflect.IAjType[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredITDMethods' and count(parameter)=0]"
		[Register ("getDeclaredITDMethods", "()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetDeclaredITDMethodsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[] GetDeclaredITDMethods ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredMethod' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getDeclaredMethod", "(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;", "GetGetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Method GetDeclaredMethod (string p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredMethods' and count(parameter)=0]"
		[Register ("getDeclaredMethods", "()[Ljava/lang/reflect/Method;", "GetGetDeclaredMethodsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Method[] GetDeclaredMethods ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredPointcut' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDeclaredPointcut", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;", "GetGetDeclaredPointcut_Ljava_lang_String_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IPointcut GetDeclaredPointcut (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getDeclaredPointcuts' and count(parameter)=0]"
		[Register ("getDeclaredPointcuts", "()[Lorg/aspectj/lang/reflect/Pointcut;", "GetGetDeclaredPointcutsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IPointcut[] GetDeclaredPointcuts ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getEnumConstants' and count(parameter)=0]"
		[Register ("getEnumConstants", "()[Ljava/lang/Object;", "GetGetEnumConstantsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Object[] GetEnumConstants ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", "GetGetField_Ljava_lang_String_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Field GetField (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getFields' and count(parameter)=0]"
		[Register ("getFields", "()[Ljava/lang/reflect/Field;", "GetGetFieldsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Field[] GetFields ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getITDConstructor' and count(parameter)=2 and parameter[1][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getITDConstructor", "(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration GetITDConstructor (global::Org.Aspectj.Lang.Reflect.IAjType p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getITDConstructors' and count(parameter)=0]"
		[Register ("getITDConstructors", "()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;", "GetGetITDConstructorsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[] GetITDConstructors ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getITDField' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;']]"
		[Register ("getITDField", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration GetITDField (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getITDFields' and count(parameter)=0]"
		[Register ("getITDFields", "()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;", "GetGetITDFieldsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[] GetITDFields ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getITDMethod' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;'] and parameter[3][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getITDMethod", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration GetITDMethod (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1, params global::Org.Aspectj.Lang.Reflect.IAjType[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getITDMethods' and count(parameter)=0]"
		[Register ("getITDMethods", "()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;", "GetGetITDMethodsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[] GetITDMethods ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getInterfaces' and count(parameter)=0]"
		[Register ("getInterfaces", "()[Lorg/aspectj/lang/reflect/AjType;", "GetGetInterfacesHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IAjType[] GetInterfaces ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getMethod' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.aspectj.lang.reflect.AjType&lt;?&gt;...']]"
		[Register ("getMethod", "(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;", "GetGetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Method GetMethod (string p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getMethods' and count(parameter)=0]"
		[Register ("getMethods", "()[Ljava/lang/reflect/Method;", "GetGetMethodsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.Method[] GetMethods ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getPointcut' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPointcut", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;", "GetGetPointcut_Ljava_lang_String_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IPointcut GetPointcut (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getPointcuts' and count(parameter)=0]"
		[Register ("getPointcuts", "()[Lorg/aspectj/lang/reflect/Pointcut;", "GetGetPointcutsHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Org.Aspectj.Lang.Reflect.IPointcut[] GetPointcuts ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='getTypeParameters' and count(parameter)=0]"
		[Register ("getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", "GetGetTypeParametersHandler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='AjType']/method[@name='isInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isInstance", "(Ljava/lang/Object;)Z", "GetIsInstance_Ljava_lang_Object_Handler:Org.Aspectj.Lang.Reflect.IAjTypeInvoker, OnepayMiuraBindingLibrary")]
		bool IsInstance (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/AjType", DoNotGenerateAcw=true)]
	internal partial class IAjTypeInvoker : global::Java.Lang.Object, IAjType {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/aspectj/lang/reflect/AjType", typeof (IAjTypeInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAjType GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAjType> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.AjType"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAjTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDeclaringType;
#pragma warning disable 0169
		static Delegate GetGetDeclaringTypeHandler ()
		{
			if (cb_getDeclaringType == null)
				cb_getDeclaringType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaringType);
			return cb_getDeclaringType;
		}

		static IntPtr n_GetDeclaringType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeclaringType);
		}
#pragma warning restore 0169

		IntPtr id_getDeclaringType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType DeclaringType {
			get {
				if (id_getDeclaringType == IntPtr.Zero)
					id_getDeclaringType = JNIEnv.GetMethodID (class_ref, "getDeclaringType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEnclosingConstructor;
#pragma warning disable 0169
		static Delegate GetGetEnclosingConstructorHandler ()
		{
			if (cb_getEnclosingConstructor == null)
				cb_getEnclosingConstructor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnclosingConstructor);
			return cb_getEnclosingConstructor;
		}

		static IntPtr n_GetEnclosingConstructor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnclosingConstructor);
		}
#pragma warning restore 0169

		IntPtr id_getEnclosingConstructor;
		public unsafe global::Java.Lang.Reflect.Constructor EnclosingConstructor {
			get {
				if (id_getEnclosingConstructor == IntPtr.Zero)
					id_getEnclosingConstructor = JNIEnv.GetMethodID (class_ref, "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnclosingConstructor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEnclosingMethod;
#pragma warning disable 0169
		static Delegate GetGetEnclosingMethodHandler ()
		{
			if (cb_getEnclosingMethod == null)
				cb_getEnclosingMethod = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnclosingMethod);
			return cb_getEnclosingMethod;
		}

		static IntPtr n_GetEnclosingMethod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnclosingMethod);
		}
#pragma warning restore 0169

		IntPtr id_getEnclosingMethod;
		public unsafe global::Java.Lang.Reflect.Method EnclosingMethod {
			get {
				if (id_getEnclosingMethod == IntPtr.Zero)
					id_getEnclosingMethod = JNIEnv.GetMethodID (class_ref, "getEnclosingMethod", "()Ljava/lang/reflect/Method;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnclosingMethod), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEnclosingType;
#pragma warning disable 0169
		static Delegate GetGetEnclosingTypeHandler ()
		{
			if (cb_getEnclosingType == null)
				cb_getEnclosingType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnclosingType);
			return cb_getEnclosingType;
		}

		static IntPtr n_GetEnclosingType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnclosingType);
		}
#pragma warning restore 0169

		IntPtr id_getEnclosingType;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType EnclosingType {
			get {
				if (id_getEnclosingType == IntPtr.Zero)
					id_getEnclosingType = JNIEnv.GetMethodID (class_ref, "getEnclosingType", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnclosingType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGenericSupertype;
#pragma warning disable 0169
		static Delegate GetGetGenericSupertypeHandler ()
		{
			if (cb_getGenericSupertype == null)
				cb_getGenericSupertype = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGenericSupertype);
			return cb_getGenericSupertype;
		}

		static IntPtr n_GetGenericSupertype (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericSupertype);
		}
#pragma warning restore 0169

		IntPtr id_getGenericSupertype;
		public unsafe global::Java.Lang.Reflect.IType GenericSupertype {
			get {
				if (id_getGenericSupertype == IntPtr.Zero)
					id_getGenericSupertype = JNIEnv.GetMethodID (class_ref, "getGenericSupertype", "()Ljava/lang/reflect/Type;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGenericSupertype), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isArray;
#pragma warning disable 0169
		static Delegate GetIsArrayHandler ()
		{
			if (cb_isArray == null)
				cb_isArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsArray);
			return cb_isArray;
		}

		static bool n_IsArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsArray;
		}
#pragma warning restore 0169

		IntPtr id_isArray;
		public unsafe bool IsArray {
			get {
				if (id_isArray == IntPtr.Zero)
					id_isArray = JNIEnv.GetMethodID (class_ref, "isArray", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isArray);
			}
		}

		static Delegate cb_isAspect;
#pragma warning disable 0169
		static Delegate GetIsAspectHandler ()
		{
			if (cb_isAspect == null)
				cb_isAspect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAspect);
			return cb_isAspect;
		}

		static bool n_IsAspect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAspect;
		}
#pragma warning restore 0169

		IntPtr id_isAspect;
		public unsafe bool IsAspect {
			get {
				if (id_isAspect == IntPtr.Zero)
					id_isAspect = JNIEnv.GetMethodID (class_ref, "isAspect", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAspect);
			}
		}

		static Delegate cb_isEnum;
#pragma warning disable 0169
		static Delegate GetIsEnumHandler ()
		{
			if (cb_isEnum == null)
				cb_isEnum = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnum);
			return cb_isEnum;
		}

		static bool n_IsEnum (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnum;
		}
#pragma warning restore 0169

		IntPtr id_isEnum;
		public unsafe bool IsEnum {
			get {
				if (id_isEnum == IntPtr.Zero)
					id_isEnum = JNIEnv.GetMethodID (class_ref, "isEnum", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnum);
			}
		}

		static Delegate cb_isInterface;
#pragma warning disable 0169
		static Delegate GetIsInterfaceHandler ()
		{
			if (cb_isInterface == null)
				cb_isInterface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInterface);
			return cb_isInterface;
		}

		static bool n_IsInterface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInterface;
		}
#pragma warning restore 0169

		IntPtr id_isInterface;
		public unsafe bool IsInterface {
			get {
				if (id_isInterface == IntPtr.Zero)
					id_isInterface = JNIEnv.GetMethodID (class_ref, "isInterface", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInterface);
			}
		}

		static Delegate cb_isLocalClass;
#pragma warning disable 0169
		static Delegate GetIsLocalClassHandler ()
		{
			if (cb_isLocalClass == null)
				cb_isLocalClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLocalClass);
			return cb_isLocalClass;
		}

		static bool n_IsLocalClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocalClass;
		}
#pragma warning restore 0169

		IntPtr id_isLocalClass;
		public unsafe bool IsLocalClass {
			get {
				if (id_isLocalClass == IntPtr.Zero)
					id_isLocalClass = JNIEnv.GetMethodID (class_ref, "isLocalClass", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocalClass);
			}
		}

		static Delegate cb_isMemberAspect;
#pragma warning disable 0169
		static Delegate GetIsMemberAspectHandler ()
		{
			if (cb_isMemberAspect == null)
				cb_isMemberAspect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMemberAspect);
			return cb_isMemberAspect;
		}

		static bool n_IsMemberAspect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMemberAspect;
		}
#pragma warning restore 0169

		IntPtr id_isMemberAspect;
		public unsafe bool IsMemberAspect {
			get {
				if (id_isMemberAspect == IntPtr.Zero)
					id_isMemberAspect = JNIEnv.GetMethodID (class_ref, "isMemberAspect", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMemberAspect);
			}
		}

		static Delegate cb_isMemberClass;
#pragma warning disable 0169
		static Delegate GetIsMemberClassHandler ()
		{
			if (cb_isMemberClass == null)
				cb_isMemberClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMemberClass);
			return cb_isMemberClass;
		}

		static bool n_IsMemberClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMemberClass;
		}
#pragma warning restore 0169

		IntPtr id_isMemberClass;
		public unsafe bool IsMemberClass {
			get {
				if (id_isMemberClass == IntPtr.Zero)
					id_isMemberClass = JNIEnv.GetMethodID (class_ref, "isMemberClass", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMemberClass);
			}
		}

		static Delegate cb_isPrimitive;
#pragma warning disable 0169
		static Delegate GetIsPrimitiveHandler ()
		{
			if (cb_isPrimitive == null)
				cb_isPrimitive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPrimitive);
			return cb_isPrimitive;
		}

		static bool n_IsPrimitive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrimitive;
		}
#pragma warning restore 0169

		IntPtr id_isPrimitive;
		public unsafe bool IsPrimitive {
			get {
				if (id_isPrimitive == IntPtr.Zero)
					id_isPrimitive = JNIEnv.GetMethodID (class_ref, "isPrimitive", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPrimitive);
			}
		}

		static Delegate cb_isPrivileged;
#pragma warning disable 0169
		static Delegate GetIsPrivilegedHandler ()
		{
			if (cb_isPrivileged == null)
				cb_isPrivileged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPrivileged);
			return cb_isPrivileged;
		}

		static bool n_IsPrivileged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPrivileged;
		}
#pragma warning restore 0169

		IntPtr id_isPrivileged;
		public unsafe bool IsPrivileged {
			get {
				if (id_isPrivileged == IntPtr.Zero)
					id_isPrivileged = JNIEnv.GetMethodID (class_ref, "isPrivileged", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPrivileged);
			}
		}

		static Delegate cb_getJavaClass;
#pragma warning disable 0169
		static Delegate GetGetJavaClassHandler ()
		{
			if (cb_getJavaClass == null)
				cb_getJavaClass = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJavaClass);
			return cb_getJavaClass;
		}

		static IntPtr n_GetJavaClass (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JavaClass);
		}
#pragma warning restore 0169

		IntPtr id_getJavaClass;
		public unsafe global::Java.Lang.Class JavaClass {
			get {
				if (id_getJavaClass == IntPtr.Zero)
					id_getJavaClass = JNIEnv.GetMethodID (class_ref, "getJavaClass", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJavaClass), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getModifiers;
#pragma warning disable 0169
		static Delegate GetGetModifiersHandler ()
		{
			if (cb_getModifiers == null)
				cb_getModifiers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetModifiers);
			return cb_getModifiers;
		}

		static int n_GetModifiers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modifiers;
		}
#pragma warning restore 0169

		IntPtr id_getModifiers;
		public unsafe int Modifiers {
			get {
				if (id_getModifiers == IntPtr.Zero)
					id_getModifiers = JNIEnv.GetMethodID (class_ref, "getModifiers", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getModifiers);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPackage;
#pragma warning disable 0169
		static Delegate GetGetPackageHandler ()
		{
			if (cb_getPackage == null)
				cb_getPackage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackage);
			return cb_getPackage;
		}

		static IntPtr n_GetPackage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Package);
		}
#pragma warning restore 0169

		IntPtr id_getPackage;
		public unsafe global::Java.Lang.Package Package {
			get {
				if (id_getPackage == IntPtr.Zero)
					id_getPackage = JNIEnv.GetMethodID (class_ref, "getPackage", "()Ljava/lang/Package;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Package> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPerClause;
#pragma warning disable 0169
		static Delegate GetGetPerClauseHandler ()
		{
			if (cb_getPerClause == null)
				cb_getPerClause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPerClause);
			return cb_getPerClause;
		}

		static IntPtr n_GetPerClause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PerClause);
		}
#pragma warning restore 0169

		IntPtr id_getPerClause;
		public unsafe global::Org.Aspectj.Lang.Reflect.IPerClause PerClause {
			get {
				if (id_getPerClause == IntPtr.Zero)
					id_getPerClause = JNIEnv.GetMethodID (class_ref, "getPerClause", "()Lorg/aspectj/lang/reflect/PerClause;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPerClause> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPerClause), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSupertype;
#pragma warning disable 0169
		static Delegate GetGetSupertypeHandler ()
		{
			if (cb_getSupertype == null)
				cb_getSupertype = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupertype);
			return cb_getSupertype;
		}

		static IntPtr n_GetSupertype (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Supertype);
		}
#pragma warning restore 0169

		IntPtr id_getSupertype;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType Supertype {
			get {
				if (id_getSupertype == IntPtr.Zero)
					id_getSupertype = JNIEnv.GetMethodID (class_ref, "getSupertype", "()Lorg/aspectj/lang/reflect/AjType;");
				return global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupertype), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdvice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAdvice_Ljava_lang_String_Handler ()
		{
			if (cb_getAdvice_Ljava_lang_String_ == null)
				cb_getAdvice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAdvice_Ljava_lang_String_);
			return cb_getAdvice_Ljava_lang_String_;
		}

		static IntPtr n_GetAdvice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAdvice (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAdvice_Ljava_lang_String_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdvice GetAdvice (string p0)
		{
			if (id_getAdvice_Ljava_lang_String_ == IntPtr.Zero)
				id_getAdvice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAdvice", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdvice_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
#pragma warning disable 0169
		static Delegate GetGetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler ()
		{
			if (cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ == null)
				cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_);
			return cb_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
		}

		static IntPtr n_GetAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Aspectj.Lang.Reflect.AdviceKind[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.AdviceKind));
			IntPtr __ret = JNIEnv.NewArray (__this.GetAdvice (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdvice[] GetAdvice (params global::Org.Aspectj.Lang.Reflect.AdviceKind[] p0)
		{
			if (id_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ == IntPtr.Zero)
				id_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ = JNIEnv.GetMethodID (class_ref, "getAdvice", "([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (global::Org.Aspectj.Lang.Reflect.IAdvice[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAdvice));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getAjTypes;
#pragma warning disable 0169
		static Delegate GetGetAjTypesHandler ()
		{
			if (cb_getAjTypes == null)
				cb_getAjTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAjTypes);
			return cb_getAjTypes;
		}

		static IntPtr n_GetAjTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAjTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getAjTypes;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetAjTypes ()
		{
			if (id_getAjTypes == IntPtr.Zero)
				id_getAjTypes = JNIEnv.GetMethodID (class_ref, "getAjTypes", "()[Lorg/aspectj/lang/reflect/AjType;");
			return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAjTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
		}

		static Delegate cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetConstructor_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetConstructor_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConstructor (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Java.Lang.Reflect.Constructor GetConstructor (params global::Org.Aspectj.Lang.Reflect.IAjType[] p0)
		{
			if (id_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getConstructor", "([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConstructor_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getConstructors;
#pragma warning disable 0169
		static Delegate GetGetConstructorsHandler ()
		{
			if (cb_getConstructors == null)
				cb_getConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConstructors);
			return cb_getConstructors;
		}

		static IntPtr n_GetConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetConstructors ());
		}
#pragma warning restore 0169

		IntPtr id_getConstructors;
		public unsafe global::Java.Lang.Reflect.Constructor[] GetConstructors ()
		{
			if (id_getConstructors == IntPtr.Zero)
				id_getConstructors = JNIEnv.GetMethodID (class_ref, "getConstructors", "()[Ljava/lang/reflect/Constructor;");
			return (global::Java.Lang.Reflect.Constructor[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConstructors), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Constructor));
		}

		static Delegate cb_getDeclareAnnotations;
#pragma warning disable 0169
		static Delegate GetGetDeclareAnnotationsHandler ()
		{
			if (cb_getDeclareAnnotations == null)
				cb_getDeclareAnnotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareAnnotations);
			return cb_getDeclareAnnotations;
		}

		static IntPtr n_GetDeclareAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareAnnotations ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclareAnnotations;
		public unsafe global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation[] GetDeclareAnnotations ()
		{
			if (id_getDeclareAnnotations == IntPtr.Zero)
				id_getDeclareAnnotations = JNIEnv.GetMethodID (class_ref, "getDeclareAnnotations", "()[Lorg/aspectj/lang/reflect/DeclareAnnotation;");
			return (global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclareAnnotations), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareAnnotation));
		}

		static Delegate cb_getDeclareErrorOrWarnings;
#pragma warning disable 0169
		static Delegate GetGetDeclareErrorOrWarningsHandler ()
		{
			if (cb_getDeclareErrorOrWarnings == null)
				cb_getDeclareErrorOrWarnings = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareErrorOrWarnings);
			return cb_getDeclareErrorOrWarnings;
		}

		static IntPtr n_GetDeclareErrorOrWarnings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareErrorOrWarnings ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclareErrorOrWarnings;
		public unsafe global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning[] GetDeclareErrorOrWarnings ()
		{
			if (id_getDeclareErrorOrWarnings == IntPtr.Zero)
				id_getDeclareErrorOrWarnings = JNIEnv.GetMethodID (class_ref, "getDeclareErrorOrWarnings", "()[Lorg/aspectj/lang/reflect/DeclareErrorOrWarning;");
			return (global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclareErrorOrWarnings), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareErrorOrWarning));
		}

		static Delegate cb_getDeclareParents;
#pragma warning disable 0169
		static Delegate GetGetDeclareParentsHandler ()
		{
			if (cb_getDeclareParents == null)
				cb_getDeclareParents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareParents);
			return cb_getDeclareParents;
		}

		static IntPtr n_GetDeclareParents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareParents ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclareParents;
		public unsafe global::Org.Aspectj.Lang.Reflect.IDeclareParents[] GetDeclareParents ()
		{
			if (id_getDeclareParents == IntPtr.Zero)
				id_getDeclareParents = JNIEnv.GetMethodID (class_ref, "getDeclareParents", "()[Lorg/aspectj/lang/reflect/DeclareParents;");
			return (global::Org.Aspectj.Lang.Reflect.IDeclareParents[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclareParents), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareParents));
		}

		static Delegate cb_getDeclarePrecedence;
#pragma warning disable 0169
		static Delegate GetGetDeclarePrecedenceHandler ()
		{
			if (cb_getDeclarePrecedence == null)
				cb_getDeclarePrecedence = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclarePrecedence);
			return cb_getDeclarePrecedence;
		}

		static IntPtr n_GetDeclarePrecedence (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclarePrecedence ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclarePrecedence;
		public unsafe global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence[] GetDeclarePrecedence ()
		{
			if (id_getDeclarePrecedence == IntPtr.Zero)
				id_getDeclarePrecedence = JNIEnv.GetMethodID (class_ref, "getDeclarePrecedence", "()[Lorg/aspectj/lang/reflect/DeclarePrecedence;");
			return (global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclarePrecedence), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclarePrecedence));
		}

		static Delegate cb_getDeclareSofts;
#pragma warning disable 0169
		static Delegate GetGetDeclareSoftsHandler ()
		{
			if (cb_getDeclareSofts == null)
				cb_getDeclareSofts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclareSofts);
			return cb_getDeclareSofts;
		}

		static IntPtr n_GetDeclareSofts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclareSofts ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclareSofts;
		public unsafe global::Org.Aspectj.Lang.Reflect.IDeclareSoft[] GetDeclareSofts ()
		{
			if (id_getDeclareSofts == IntPtr.Zero)
				id_getDeclareSofts = JNIEnv.GetMethodID (class_ref, "getDeclareSofts", "()[Lorg/aspectj/lang/reflect/DeclareSoft;");
			return (global::Org.Aspectj.Lang.Reflect.IDeclareSoft[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclareSofts), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IDeclareSoft));
		}

		static Delegate cb_getDeclaredAdvice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAdvice_Ljava_lang_String_Handler ()
		{
			if (cb_getDeclaredAdvice_Ljava_lang_String_ == null)
				cb_getDeclaredAdvice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredAdvice_Ljava_lang_String_);
			return cb_getDeclaredAdvice_Ljava_lang_String_;
		}

		static IntPtr n_GetDeclaredAdvice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredAdvice (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredAdvice_Ljava_lang_String_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdvice GetDeclaredAdvice (string p0)
		{
			if (id_getDeclaredAdvice_Ljava_lang_String_ == IntPtr.Zero)
				id_getDeclaredAdvice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDeclaredAdvice", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Advice;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAdvice> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredAdvice_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_Handler ()
		{
			if (cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ == null)
				cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_);
			return cb_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
		}

		static IntPtr n_GetDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Aspectj.Lang.Reflect.AdviceKind[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.AdviceKind));
			IntPtr __ret = JNIEnv.NewArray (__this.GetDeclaredAdvice (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAdvice[] GetDeclaredAdvice (params global::Org.Aspectj.Lang.Reflect.AdviceKind[] p0)
		{
			if (id_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ == IntPtr.Zero)
				id_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_ = JNIEnv.GetMethodID (class_ref, "getDeclaredAdvice", "([Lorg/aspectj/lang/reflect/AdviceKind;)[Lorg/aspectj/lang/reflect/Advice;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (global::Org.Aspectj.Lang.Reflect.IAdvice[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredAdvice_arrayLorg_aspectj_lang_reflect_AdviceKind_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAdvice));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getDeclaredAjTypes;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAjTypesHandler ()
		{
			if (cb_getDeclaredAjTypes == null)
				cb_getDeclaredAjTypes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredAjTypes);
			return cb_getDeclaredAjTypes;
		}

		static IntPtr n_GetDeclaredAjTypes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredAjTypes ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredAjTypes;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetDeclaredAjTypes ()
		{
			if (id_getDeclaredAjTypes == IntPtr.Zero)
				id_getDeclaredAjTypes = JNIEnv.GetMethodID (class_ref, "getDeclaredAjTypes", "()[Lorg/aspectj/lang/reflect/AjType;");
			return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredAjTypes), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
		}

		static Delegate cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredConstructor (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Java.Lang.Reflect.Constructor GetDeclaredConstructor (params global::Org.Aspectj.Lang.Reflect.IAjType[] p0)
		{
			if (id_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getDeclaredConstructor", "([Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Constructor;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Constructor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredConstructor_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getDeclaredConstructors;
#pragma warning disable 0169
		static Delegate GetGetDeclaredConstructorsHandler ()
		{
			if (cb_getDeclaredConstructors == null)
				cb_getDeclaredConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredConstructors);
			return cb_getDeclaredConstructors;
		}

		static IntPtr n_GetDeclaredConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredConstructors ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredConstructors;
		public unsafe global::Java.Lang.Reflect.Constructor[] GetDeclaredConstructors ()
		{
			if (id_getDeclaredConstructors == IntPtr.Zero)
				id_getDeclaredConstructors = JNIEnv.GetMethodID (class_ref, "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;");
			return (global::Java.Lang.Reflect.Constructor[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredConstructors), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Constructor));
		}

		static Delegate cb_getDeclaredField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredField_Ljava_lang_String_Handler ()
		{
			if (cb_getDeclaredField_Ljava_lang_String_ == null)
				cb_getDeclaredField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredField_Ljava_lang_String_);
			return cb_getDeclaredField_Ljava_lang_String_;
		}

		static IntPtr n_GetDeclaredField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredField (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredField_Ljava_lang_String_;
		public unsafe global::Java.Lang.Reflect.Field GetDeclaredField (string p0)
		{
			if (id_getDeclaredField_Ljava_lang_String_ == IntPtr.Zero)
				id_getDeclaredField_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredField_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDeclaredFields;
#pragma warning disable 0169
		static Delegate GetGetDeclaredFieldsHandler ()
		{
			if (cb_getDeclaredFields == null)
				cb_getDeclaredFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredFields);
			return cb_getDeclaredFields;
		}

		static IntPtr n_GetDeclaredFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredFields ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredFields;
		public unsafe global::Java.Lang.Reflect.Field[] GetDeclaredFields ()
		{
			if (id_getDeclaredFields == IntPtr.Zero)
				id_getDeclaredFields = JNIEnv.GetMethodID (class_ref, "getDeclaredFields", "()[Ljava/lang/reflect/Field;");
			return (global::Java.Lang.Reflect.Field[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredFields), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Field));
		}

		static Delegate cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredITDConstructor (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration GetDeclaredITDConstructor (global::Org.Aspectj.Lang.Reflect.IAjType p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1)
		{
			if (id_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getDeclaredITDConstructor", "(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getDeclaredITDConstructors;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDConstructorsHandler ()
		{
			if (cb_getDeclaredITDConstructors == null)
				cb_getDeclaredITDConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredITDConstructors);
			return cb_getDeclaredITDConstructors;
		}

		static IntPtr n_GetDeclaredITDConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredITDConstructors ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredITDConstructors;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[] GetDeclaredITDConstructors ()
		{
			if (id_getDeclaredITDConstructors == IntPtr.Zero)
				id_getDeclaredITDConstructors = JNIEnv.GetMethodID (class_ref, "getDeclaredITDConstructors", "()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;");
			return (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredITDConstructors), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration));
		}

		static Delegate cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredITDField (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration GetDeclaredITDField (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1)
		{
			if (id_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getDeclaredITDField", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDeclaredITDFields;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDFieldsHandler ()
		{
			if (cb_getDeclaredITDFields == null)
				cb_getDeclaredITDFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredITDFields);
			return cb_getDeclaredITDFields;
		}

		static IntPtr n_GetDeclaredITDFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredITDFields ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredITDFields;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[] GetDeclaredITDFields ()
		{
			if (id_getDeclaredITDFields == IntPtr.Zero)
				id_getDeclaredITDFields = JNIEnv.GetMethodID (class_ref, "getDeclaredITDFields", "()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;");
			return (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredITDFields), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration));
		}

		static Delegate cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredITDMethod (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration GetDeclaredITDMethod (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1, params global::Org.Aspectj.Lang.Reflect.IAjType[] p2)
		{
			if (id_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getDeclaredITDMethod", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_getDeclaredITDMethods;
#pragma warning disable 0169
		static Delegate GetGetDeclaredITDMethodsHandler ()
		{
			if (cb_getDeclaredITDMethods == null)
				cb_getDeclaredITDMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredITDMethods);
			return cb_getDeclaredITDMethods;
		}

		static IntPtr n_GetDeclaredITDMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredITDMethods ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredITDMethods;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[] GetDeclaredITDMethods ()
		{
			if (id_getDeclaredITDMethods == IntPtr.Zero)
				id_getDeclaredITDMethods = JNIEnv.GetMethodID (class_ref, "getDeclaredITDMethods", "()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;");
			return (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredITDMethods), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration));
		}

		static Delegate cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredMethod (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Java.Lang.Reflect.Method GetDeclaredMethod (string p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1)
		{
			if (id_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getDeclaredMethod", "(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getDeclaredMethods;
#pragma warning disable 0169
		static Delegate GetGetDeclaredMethodsHandler ()
		{
			if (cb_getDeclaredMethods == null)
				cb_getDeclaredMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredMethods);
			return cb_getDeclaredMethods;
		}

		static IntPtr n_GetDeclaredMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredMethods ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredMethods;
		public unsafe global::Java.Lang.Reflect.Method[] GetDeclaredMethods ()
		{
			if (id_getDeclaredMethods == IntPtr.Zero)
				id_getDeclaredMethods = JNIEnv.GetMethodID (class_ref, "getDeclaredMethods", "()[Ljava/lang/reflect/Method;");
			return (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredMethods), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
		}

		static Delegate cb_getDeclaredPointcut_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDeclaredPointcut_Ljava_lang_String_Handler ()
		{
			if (cb_getDeclaredPointcut_Ljava_lang_String_ == null)
				cb_getDeclaredPointcut_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDeclaredPointcut_Ljava_lang_String_);
			return cb_getDeclaredPointcut_Ljava_lang_String_;
		}

		static IntPtr n_GetDeclaredPointcut_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeclaredPointcut (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredPointcut_Ljava_lang_String_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IPointcut GetDeclaredPointcut (string p0)
		{
			if (id_getDeclaredPointcut_Ljava_lang_String_ == IntPtr.Zero)
				id_getDeclaredPointcut_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDeclaredPointcut", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredPointcut_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getDeclaredPointcuts;
#pragma warning disable 0169
		static Delegate GetGetDeclaredPointcutsHandler ()
		{
			if (cb_getDeclaredPointcuts == null)
				cb_getDeclaredPointcuts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredPointcuts);
			return cb_getDeclaredPointcuts;
		}

		static IntPtr n_GetDeclaredPointcuts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredPointcuts ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredPointcuts;
		public unsafe global::Org.Aspectj.Lang.Reflect.IPointcut[] GetDeclaredPointcuts ()
		{
			if (id_getDeclaredPointcuts == IntPtr.Zero)
				id_getDeclaredPointcuts = JNIEnv.GetMethodID (class_ref, "getDeclaredPointcuts", "()[Lorg/aspectj/lang/reflect/Pointcut;");
			return (global::Org.Aspectj.Lang.Reflect.IPointcut[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredPointcuts), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IPointcut));
		}

		static Delegate cb_getEnumConstants;
#pragma warning disable 0169
		static Delegate GetGetEnumConstantsHandler ()
		{
			if (cb_getEnumConstants == null)
				cb_getEnumConstants = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEnumConstants);
			return cb_getEnumConstants;
		}

		static IntPtr n_GetEnumConstants (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEnumConstants ());
		}
#pragma warning restore 0169

		IntPtr id_getEnumConstants;
		public unsafe global::Java.Lang.Object[] GetEnumConstants ()
		{
			if (id_getEnumConstants == IntPtr.Zero)
				id_getEnumConstants = JNIEnv.GetMethodID (class_ref, "getEnumConstants", "()[Ljava/lang/Object;");
			return (global::Java.Lang.Object[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnumConstants), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
		}

		static Delegate cb_getField_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetField_Ljava_lang_String_Handler ()
		{
			if (cb_getField_Ljava_lang_String_ == null)
				cb_getField_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetField_Ljava_lang_String_);
			return cb_getField_Ljava_lang_String_;
		}

		static IntPtr n_GetField_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetField (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getField_Ljava_lang_String_;
		public unsafe global::Java.Lang.Reflect.Field GetField (string p0)
		{
			if (id_getField_Ljava_lang_String_ == IntPtr.Zero)
				id_getField_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getField_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFields;
#pragma warning disable 0169
		static Delegate GetGetFieldsHandler ()
		{
			if (cb_getFields == null)
				cb_getFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFields);
			return cb_getFields;
		}

		static IntPtr n_GetFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFields ());
		}
#pragma warning restore 0169

		IntPtr id_getFields;
		public unsafe global::Java.Lang.Reflect.Field[] GetFields ()
		{
			if (id_getFields == IntPtr.Zero)
				id_getFields = JNIEnv.GetMethodID (class_ref, "getFields", "()[Ljava/lang/reflect/Field;");
			return (global::Java.Lang.Reflect.Field[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFields), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Field));
		}

		static Delegate cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetITDConstructor (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration GetITDConstructor (global::Org.Aspectj.Lang.Reflect.IAjType p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1)
		{
			if (id_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getITDConstructor", "(Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getITDConstructor_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getITDConstructors;
#pragma warning disable 0169
		static Delegate GetGetITDConstructorsHandler ()
		{
			if (cb_getITDConstructors == null)
				cb_getITDConstructors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetITDConstructors);
			return cb_getITDConstructors;
		}

		static IntPtr n_GetITDConstructors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetITDConstructors ());
		}
#pragma warning restore 0169

		IntPtr id_getITDConstructors;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[] GetITDConstructors ()
		{
			if (id_getITDConstructors == IntPtr.Zero)
				id_getITDConstructors = JNIEnv.GetMethodID (class_ref, "getITDConstructors", "()[Lorg/aspectj/lang/reflect/InterTypeConstructorDeclaration;");
			return (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getITDConstructors), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeConstructorDeclaration));
		}

		static Delegate cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ == null)
				cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_);
			return cb_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetITDField (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration GetITDField (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1)
		{
			if (id_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getITDField", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getITDField_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getITDFields;
#pragma warning disable 0169
		static Delegate GetGetITDFieldsHandler ()
		{
			if (cb_getITDFields == null)
				cb_getITDFields = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetITDFields);
			return cb_getITDFields;
		}

		static IntPtr n_GetITDFields (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetITDFields ());
		}
#pragma warning restore 0169

		IntPtr id_getITDFields;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[] GetITDFields ()
		{
			if (id_getITDFields == IntPtr.Zero)
				id_getITDFields = JNIEnv.GetMethodID (class_ref, "getITDFields", "()[Lorg/aspectj/lang/reflect/InterTypeFieldDeclaration;");
			return (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getITDFields), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeFieldDeclaration));
		}

		static Delegate cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetITDMethod (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration GetITDMethod (string p0, global::Org.Aspectj.Lang.Reflect.IAjType p1, params global::Org.Aspectj.Lang.Reflect.IAjType[] p2)
		{
			if (id_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getITDMethod", "(Ljava/lang/String;Lorg/aspectj/lang/reflect/AjType;[Lorg/aspectj/lang/reflect/AjType;)Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getITDMethod_Ljava_lang_String_Lorg_aspectj_lang_reflect_AjType_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_getITDMethods;
#pragma warning disable 0169
		static Delegate GetGetITDMethodsHandler ()
		{
			if (cb_getITDMethods == null)
				cb_getITDMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetITDMethods);
			return cb_getITDMethods;
		}

		static IntPtr n_GetITDMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetITDMethods ());
		}
#pragma warning restore 0169

		IntPtr id_getITDMethods;
		public unsafe global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[] GetITDMethods ()
		{
			if (id_getITDMethods == IntPtr.Zero)
				id_getITDMethods = JNIEnv.GetMethodID (class_ref, "getITDMethods", "()[Lorg/aspectj/lang/reflect/InterTypeMethodDeclaration;");
			return (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getITDMethods), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IInterTypeMethodDeclaration));
		}

		static Delegate cb_getInterfaces;
#pragma warning disable 0169
		static Delegate GetGetInterfacesHandler ()
		{
			if (cb_getInterfaces == null)
				cb_getInterfaces = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInterfaces);
			return cb_getInterfaces;
		}

		static IntPtr n_GetInterfaces (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetInterfaces ());
		}
#pragma warning restore 0169

		IntPtr id_getInterfaces;
		public unsafe global::Org.Aspectj.Lang.Reflect.IAjType[] GetInterfaces ()
		{
			if (id_getInterfaces == IntPtr.Zero)
				id_getInterfaces = JNIEnv.GetMethodID (class_ref, "getInterfaces", "()[Lorg/aspectj/lang/reflect/AjType;");
			return (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInterfaces), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
		}

		static Delegate cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
#pragma warning disable 0169
		static Delegate GetGetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_Handler ()
		{
			if (cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ == null)
				cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_);
			return cb_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
		}

		static IntPtr n_GetMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Org.Aspectj.Lang.Reflect.IAjType[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Aspectj.Lang.Reflect.IAjType));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMethod (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_;
		public unsafe global::Java.Lang.Reflect.Method GetMethod (string p0, params global::Org.Aspectj.Lang.Reflect.IAjType[] p1)
		{
			if (id_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ == IntPtr.Zero)
				id_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_ = JNIEnv.GetMethodID (class_ref, "getMethod", "(Ljava/lang/String;[Lorg/aspectj/lang/reflect/AjType;)Ljava/lang/reflect/Method;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethod_Ljava_lang_String_arrayLorg_aspectj_lang_reflect_AjType_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getMethods;
#pragma warning disable 0169
		static Delegate GetGetMethodsHandler ()
		{
			if (cb_getMethods == null)
				cb_getMethods = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMethods);
			return cb_getMethods;
		}

		static IntPtr n_GetMethods (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMethods ());
		}
#pragma warning restore 0169

		IntPtr id_getMethods;
		public unsafe global::Java.Lang.Reflect.Method[] GetMethods ()
		{
			if (id_getMethods == IntPtr.Zero)
				id_getMethods = JNIEnv.GetMethodID (class_ref, "getMethods", "()[Ljava/lang/reflect/Method;");
			return (global::Java.Lang.Reflect.Method[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMethods), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.Method));
		}

		static Delegate cb_getPointcut_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPointcut_Ljava_lang_String_Handler ()
		{
			if (cb_getPointcut_Ljava_lang_String_ == null)
				cb_getPointcut_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPointcut_Ljava_lang_String_);
			return cb_getPointcut_Ljava_lang_String_;
		}

		static IntPtr n_GetPointcut_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPointcut (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPointcut_Ljava_lang_String_;
		public unsafe global::Org.Aspectj.Lang.Reflect.IPointcut GetPointcut (string p0)
		{
			if (id_getPointcut_Ljava_lang_String_ == IntPtr.Zero)
				id_getPointcut_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPointcut", "(Ljava/lang/String;)Lorg/aspectj/lang/reflect/Pointcut;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IPointcut> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPointcut_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPointcuts;
#pragma warning disable 0169
		static Delegate GetGetPointcutsHandler ()
		{
			if (cb_getPointcuts == null)
				cb_getPointcuts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPointcuts);
			return cb_getPointcuts;
		}

		static IntPtr n_GetPointcuts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPointcuts ());
		}
#pragma warning restore 0169

		IntPtr id_getPointcuts;
		public unsafe global::Org.Aspectj.Lang.Reflect.IPointcut[] GetPointcuts ()
		{
			if (id_getPointcuts == IntPtr.Zero)
				id_getPointcuts = JNIEnv.GetMethodID (class_ref, "getPointcuts", "()[Lorg/aspectj/lang/reflect/Pointcut;");
			return (global::Org.Aspectj.Lang.Reflect.IPointcut[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPointcuts), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Aspectj.Lang.Reflect.IPointcut));
		}

		static Delegate cb_getTypeParameters;
#pragma warning disable 0169
		static Delegate GetGetTypeParametersHandler ()
		{
			if (cb_getTypeParameters == null)
				cb_getTypeParameters = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypeParameters);
			return cb_getTypeParameters;
		}

		static IntPtr n_GetTypeParameters (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTypeParameters ());
		}
#pragma warning restore 0169

		IntPtr id_getTypeParameters;
		public unsafe global::Java.Lang.Reflect.ITypeVariable[] GetTypeParameters ()
		{
			if (id_getTypeParameters == IntPtr.Zero)
				id_getTypeParameters = JNIEnv.GetMethodID (class_ref, "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;");
			return (global::Java.Lang.Reflect.ITypeVariable[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypeParameters), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Reflect.ITypeVariable));
		}

		static Delegate cb_isInstance_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsInstance_Ljava_lang_Object_Handler ()
		{
			if (cb_isInstance_Ljava_lang_Object_ == null)
				cb_isInstance_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsInstance_Ljava_lang_Object_);
			return cb_isInstance_Ljava_lang_Object_;
		}

		static bool n_IsInstance_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInstance (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isInstance_Ljava_lang_Object_;
		public unsafe bool IsInstance (global::Java.Lang.Object p0)
		{
			if (id_isInstance_Ljava_lang_Object_ == IntPtr.Zero)
				id_isInstance_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isInstance", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInstance_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_getAnnotation_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetAnnotation_Ljava_lang_Class_Handler ()
		{
			if (cb_getAnnotation_Ljava_lang_Class_ == null)
				cb_getAnnotation_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAnnotation_Ljava_lang_Class_);
			return cb_getAnnotation_Ljava_lang_Class_;
		}

		static IntPtr n_GetAnnotation_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var annotationClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_annotationClass, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAnnotation (annotationClass));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAnnotation_Ljava_lang_Class_;
		public unsafe global::Java.Lang.Object GetAnnotation (global::Java.Lang.Class annotationClass)
		{
			if (id_getAnnotation_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAnnotation_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((annotationClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotationClass).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotation_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getAnnotations;
#pragma warning disable 0169
		static Delegate GetGetAnnotationsHandler ()
		{
			if (cb_getAnnotations == null)
				cb_getAnnotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAnnotations);
			return cb_getAnnotations;
		}

		static IntPtr n_GetAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAnnotations ());
		}
#pragma warning restore 0169

		IntPtr id_getAnnotations;
		public unsafe global::Java.Lang.Annotation.IAnnotation[] GetAnnotations ()
		{
			if (id_getAnnotations == IntPtr.Zero)
				id_getAnnotations = JNIEnv.GetMethodID (class_ref, "getAnnotations", "()[Ljava/lang/annotation/Annotation;");
			return (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotations), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Annotation.IAnnotation));
		}

		static Delegate cb_getDeclaredAnnotations;
#pragma warning disable 0169
		static Delegate GetGetDeclaredAnnotationsHandler ()
		{
			if (cb_getDeclaredAnnotations == null)
				cb_getDeclaredAnnotations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeclaredAnnotations);
			return cb_getDeclaredAnnotations;
		}

		static IntPtr n_GetDeclaredAnnotations (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDeclaredAnnotations ());
		}
#pragma warning restore 0169

		IntPtr id_getDeclaredAnnotations;
		public unsafe global::Java.Lang.Annotation.IAnnotation[] GetDeclaredAnnotations ()
		{
			if (id_getDeclaredAnnotations == IntPtr.Zero)
				id_getDeclaredAnnotations = JNIEnv.GetMethodID (class_ref, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			return (global::Java.Lang.Annotation.IAnnotation[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredAnnotations), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Annotation.IAnnotation));
		}

		static Delegate cb_isAnnotationPresent_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetIsAnnotationPresent_Ljava_lang_Class_Handler ()
		{
			if (cb_isAnnotationPresent_Ljava_lang_Class_ == null)
				cb_isAnnotationPresent_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsAnnotationPresent_Ljava_lang_Class_);
			return cb_isAnnotationPresent_Ljava_lang_Class_;
		}

		static bool n_IsAnnotationPresent_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_annotationClass)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.IAjType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var annotationClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_annotationClass, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAnnotationPresent (annotationClass);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isAnnotationPresent_Ljava_lang_Class_;
		public unsafe global::System.Boolean IsAnnotationPresent (global::Java.Lang.Class annotationClass)
		{
			if (id_isAnnotationPresent_Ljava_lang_Class_ == IntPtr.Zero)
				id_isAnnotationPresent_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "isAnnotationPresent", "(Ljava/lang/Class;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((annotationClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotationClass).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAnnotationPresent_Ljava_lang_Class_, __args);
			return __ret;
		}

	}

}
