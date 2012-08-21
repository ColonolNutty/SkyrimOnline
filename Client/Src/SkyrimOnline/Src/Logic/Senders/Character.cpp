#include "stdafx.h"
#include <Logic/Session.h>
#include <SkyrimOnline.h>

namespace Skyrim
{
	namespace Logic
	{
		//--------------------------------------------------------------------------------
		void Session::SendCharacterInfo(Game::Character& pCharacter)
		{
			Network::Packet data(Opcode::CMSG_CHARACTER_INFO, 0xFFFFFFFF);
			data << pCharacter.GetRace() 
				 << pCharacter.GetGender() 
				 << pCharacter.GetLevel()
				 << pCharacter.GetFaceMorph()
				 << pCharacter.GetAllWornForms()
				 << pCharacter.GetLocationId();
			
			Write(data);
		}
		//--------------------------------------------------------------------------------
		void Session::SendMoveAndLook(Game::Character& pCharacter, uint32_t pDelta)
		{
			Network::Packet data(Opcode::CMSG_MOVE_AND_LOOK, 0xFFFFFFFF);
			data << pCharacter.GetPosX() << pCharacter.GetPosY() << pCharacter.GetPosZ()
				 << pCharacter.GetRotX() << pCharacter.GetRotY() << pCharacter.GetRotZ()
				 << pDelta;

			Write(data);
		}
		//--------------------------------------------------------------------------------
		void Session::SendMount(uint32_t pId)
		{
			Network::Packet mount(Opcode::CMSG_MOUNT_SPAWN, pId);
			Write(mount);
		}
		//--------------------------------------------------------------------------------
		void Session::SendUnmount()
		{
			Network::Packet mount(Opcode::CMSG_MOUNT_REMOVE, 0xFFFFFFFF);
			Write(mount);
		}
		//--------------------------------------------------------------------------------
		void Session::SendEnterRegion(uint32_t pRegion)
		{	
			Network::Packet region(Opcode::CMSG_ENTER_REGION, 0xFFFFFFFF);
			region << pRegion;
			Write(region);
		}
		//--------------------------------------------------------------------------------
	}
}