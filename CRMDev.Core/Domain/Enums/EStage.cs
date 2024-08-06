﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMDev.Core.Domain.Enums
{
    public enum EStage
    {
        ContactMade,          // ContatoFeito
        PreQualification,     // PreQualificacao
        Connection,           // Conexao
        MeetingScheduled,     // ReuniaoAgendada
        ProposalSent,         // PropostaEnviada
        AwaitingSignature,    // AguardandoAssinatura
        Closed                // Fechado
    }
}