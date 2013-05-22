using System;
using ProtoBuf;

namespace Messages
{
	
[ProtoContract]
public class Message{
		
	public enum MessageType {
		DISP_PLAY = 0,
		DISP_PLAY_CANCEL = 1,
		LOG_OK = 2,
		LOG = 3,
		USER_AVAILABLE_PLAY = 4,
		USER_AVAILABLE_PLAY_CANCEL = 5
	}
		
	[ProtoMember(1)]
	public MessageType messageType {get;set;}
	
	[ProtoMember(2)]
	public string username {get;set;}
		
		
	[ProtoContract]
	public class Login{
	   [ProtoMember(2)]
	    public string password {get;set;}
	}
	
	[ProtoMember(3)]
	public Login login {get;set;}
	
}
	


}

