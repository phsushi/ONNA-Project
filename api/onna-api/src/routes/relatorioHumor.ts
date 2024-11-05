import { Router } from "express"

import { criar_Relatorio_Humor, criar_Relatorio_Remedio, criar_Relatorio_Atividade, exibir_Relatorio_Humor, exibir_Relatorio_Remedio, exibir_Relatorio_Atividade} from "../controllers/relatorioHumor"

const relatorioHumorRoutes:Router = Router()  

relatorioHumorRoutes.post("/relatorioHumor", criar_Relatorio_Humor)
relatorioHumorRoutes.post("/relatorioHumor", criar_Relatorio_Remedio)
relatorioHumorRoutes.post("/relatorioHumor", criar_Relatorio_Atividade)

relatorioHumorRoutes.get("/relatorioHumor/:idUsuario/:data_Relatorio", exibir_Relatorio_Humor)
relatorioHumorRoutes.get("/relatorioHumor/:idUsuario/:data_Relatorio", exibir_Relatorio_Humorxibir_Relatorio_Remedio)
relatorioHumorRoutes.get("/relatorioHumor/:idUsuario/:data_Relatorio", exibir_Relatorio_Atividade)

export default relatorioHumorRoutes
