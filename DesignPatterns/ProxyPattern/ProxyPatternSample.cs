﻿using System;
using DesignPatterns.ProxyPattern.Protection;
using DesignPatterns.ProxyPattern.Remote;
using DesignPatterns.ProxyPattern.Virtual;

namespace DesignPatterns.ProxyPattern {
  public class ProxyPatternSample : IDesignPatternSample {
    public void ShowSample() {
      VirtualProxySample();
      ProtectionProxySample();
      RemoteProxySample();
    }

    private static void VirtualProxySample() {
      IExampleExpensiveObject withProxy = new VirtualProxy("JIT");
      IExampleExpensiveObject withoutProxy = new ExampleExpensiveObject("AOT");
      Console.Out.WriteLine(withoutProxy.Text);
      Console.Out.WriteLine(withProxy.Text);
    }

    private static void ProtectionProxySample() {
      var classWithoutPermission = new ProtectionProxy(false);
      ErrorUtilities.LogException(classWithoutPermission.SensitiveMethod);

      var classWithPermission = new ProtectionProxy(true);
      Console.Out.WriteLine(classWithPermission.SensitiveMethod());
    }

    private static void RemoteProxySample() {
      var remoteProxy = new RemoteProxy();
      Console.Out.WriteLine($"Will block until I get this data: {remoteProxy.GetData()}");
    }
  }
}
