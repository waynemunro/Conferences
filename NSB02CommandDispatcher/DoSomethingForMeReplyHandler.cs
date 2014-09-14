using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSB02SampleMessages;
using Topics.Radical;

namespace NSB02CommandDispatcher
{
	class DoSomethingForMeReplyHandler : NServiceBus.IHandleMessages<DoSomethingForMeReply>
	{
		public void Handle( DoSomethingForMeReply message )
		{
			using ( ConsoleColor.Cyan.AsForegroundColor() )
			{
				Console.WriteLine( "Received a reply: {0}", message.Content );
			}
		}
	}
}
