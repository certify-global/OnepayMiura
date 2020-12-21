using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi", Managed="Com.Miurasystems.Mpi")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.api.executor", Managed="Com.Miurasystems.Mpi.Api.Executor")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.api.listener", Managed="Com.Miurasystems.Mpi.Api.Listener")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.api.objects", Managed="Com.Miurasystems.Mpi.Api.Objects")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.api.utils", Managed="Com.Miurasystems.Mpi.Api.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.aspects", Managed="Com.Miurasystems.Mpi.Aspects")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.comms", Managed="Com.Miurasystems.Mpi.Comms")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.enums", Managed="Com.Miurasystems.Mpi.Enums")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.errors", Managed="Com.Miurasystems.Mpi.Errors")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.events", Managed="Com.Miurasystems.Mpi.Events")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.tlv", Managed="Com.Miurasystems.Mpi.Tlv")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.mpi.update", Managed="Com.Miurasystems.Mpi.Update")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.transactions", Managed="Com.Miurasystems.Transactions")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.transactions.emv", Managed="Com.Miurasystems.Transactions.Emv")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.miurasystems.transactions.magswipe", Managed="Com.Miurasystems.Transactions.Magswipe")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura", Managed="Com.Onepay.Miura")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura.api", Managed="Com.Onepay.Miura.Api")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura.bluetooth", Managed="Com.Onepay.Miura.Bluetooth")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura.common", Managed="Com.Onepay.Miura.Common")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura.core", Managed="Com.Onepay.Miura.Core")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura.data", Managed="Com.Onepay.Miura.Data")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura.transactions", Managed="Com.Onepay.Miura.Transactions")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.onepay.miura.utils", Managed="Com.Onepay.Miura.Utils")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.internal.lang.annotation", Managed="Org.Aspectj.Internal.Lang.Annotation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.internal.lang.reflect", Managed="Org.Aspectj.Internal.Lang.Reflect")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.lang", Managed="Org.Aspectj.Lang")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.lang.annotation", Managed="Org.Aspectj.Lang.Annotation")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.lang.annotation.control", Managed="Org.Aspectj.Lang.Annotation.Control")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.lang.reflect", Managed="Org.Aspectj.Lang.Reflect")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.runtime", Managed="Org.Aspectj.Runtime")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.runtime.internal", Managed="Org.Aspectj.Runtime.Internal")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.runtime.internal.cflowstack", Managed="Org.Aspectj.Runtime.Internal.Cflowstack")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.aspectj.runtime.reflect", Managed="Org.Aspectj.Runtime.Reflect")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.slf4j", Managed="Org.Slf4j")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.slf4j.event", Managed="Org.Slf4j.Event")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.slf4j.helpers", Managed="Org.Slf4j.Helpers")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "org.slf4j.spi", Managed="Org.Slf4j.Spi")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PPD_V (IntPtr jnienv, IntPtr klass, double p0);
delegate void _JniMarshal_PPDLLI_V (IntPtr jnienv, IntPtr klass, double p0, IntPtr p1, IntPtr p2, int p3);
delegate void _JniMarshal_PPDLLIZ_V (IntPtr jnienv, IntPtr klass, double p0, IntPtr p1, IntPtr p2, int p3, bool p4);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPII_L (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate IntPtr _JniMarshal_PPIIII_L (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIIL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPIILLL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPIILLZZL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2, IntPtr p3, bool p4, bool p5, IntPtr p6);
delegate bool _JniMarshal_PPIL_Z (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPILL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate bool _JniMarshal_PPJ_Z (IntPtr jnienv, IntPtr klass, long p0);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPLIII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPLIIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLIILL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPLIILL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPLIILLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3, IntPtr p4, IntPtr p5);
delegate IntPtr _JniMarshal_PPLIILLZZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3, IntPtr p4, bool p5, bool p6);
delegate void _JniMarshal_PPLIIZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, bool p3, IntPtr p4);
delegate void _JniMarshal_PPLIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLJ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate int _JniMarshal_PPLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3);
delegate bool _JniMarshal_PPLLIIII_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, int p4, int p5);
delegate IntPtr _JniMarshal_PPLLIIL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, IntPtr p4);
delegate IntPtr _JniMarshal_PPLLIILL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, IntPtr p4, IntPtr p5);
delegate IntPtr _JniMarshal_PPLLIIZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, bool p4);
delegate void _JniMarshal_PPLLILLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, IntPtr p3, IntPtr p4, IntPtr p5);
delegate int _JniMarshal_PPLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate bool _JniMarshal_PPLLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate int _JniMarshal_PPLLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLLLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate bool _JniMarshal_PPLLZZZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2, bool p3, bool p4);
delegate IntPtr _JniMarshal_PPLZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate bool _JniMarshal_PPLZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate void _JniMarshal_PPLZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, IntPtr p2);
delegate bool _JniMarshal_PPLZZ_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2);
delegate void _JniMarshal_PPLZZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLZZZZZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2, bool p3, bool p4, bool p5);
delegate void _JniMarshal_PPLZZZZZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2, bool p3, bool p4, bool p5);
delegate IntPtr _JniMarshal_PPLZZZZZZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2, bool p3, bool p4, bool p5, bool p6);
delegate void _JniMarshal_PPLZZZZZZ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, bool p2, bool p3, bool p4, bool p5, bool p6);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate bool _JniMarshal_PPZ_Z (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPZLIIIILL_L (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1, int p2, int p3, int p4, int p5, IntPtr p6, IntPtr p7);
delegate void _JniMarshal_PPZLIIIILLL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1, int p2, int p3, int p4, int p5, IntPtr p6, IntPtr p7, IntPtr p8);
delegate IntPtr _JniMarshal_PPZLLL_L (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPZLLLL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate IntPtr _JniMarshal_PPZZ_L (IntPtr jnienv, IntPtr klass, bool p0, bool p1);
delegate void _JniMarshal_PPZZL_V (IntPtr jnienv, IntPtr klass, bool p0, bool p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPZZZZZLL_L (IntPtr jnienv, IntPtr klass, bool p0, bool p1, bool p2, bool p3, bool p4, IntPtr p5, IntPtr p6);
delegate void _JniMarshal_PPZZZZZLLL_V (IntPtr jnienv, IntPtr klass, bool p0, bool p1, bool p2, bool p3, bool p4, IntPtr p5, IntPtr p6, IntPtr p7);
