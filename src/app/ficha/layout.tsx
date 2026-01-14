import { Atributos } from "../components/info/header/Atributos";
import { TestesResistencia } from "../components/info/header/TestesResistencia";
import { Label } from "@/src/app/components/ui/label"
import { Input } from "../components/ui/input";
import { Identidade } from "../components/info/header/Identidade";

export default function FichaLayout() {
  return (
    <section className="flex gap-8 items-start">

      {/* CARD ESQUERDO */}
      <section className="w-[711.6px]">

        {/* HEADER */}
        <header className="flex gap-12 border-b border-pink-400 p-4">
          <h2 className="sr-only">Atributos e Testes de Resistência</h2>
          <div>
            <Identidade />  
          </div>

          <div>  
            <Atributos /> 
          </div>

          <div>  
            <TestesResistencia />   
          </div>
        </header>

        {/* BODY */}
        <section className="grid grid-cols-2 gap-6 p-6">
          
          {/* INFORMAÇÕES BÁSICAS */}
          <section>
            <h2 className="sr-only">Informações Básicas</h2>
            {/* conteúdo */}
          </section>

          {/* PERÍCIAS */}
          <section>
            <h2 className="sr-only">Perícias</h2>
            {/* conteúdo */}
          </section>

        </section>
      </section>

      {/* CARD DIREITO */}
      <section className="flex-1 max-w-md">

        {/* NAVBAR (HEADER) */}
        <header>
          <nav className="flex">
            <button className="px-4 py-2 font-medium border-b-2 border-pink-400">
              FAVORITOS
            </button>
            <button className="px-4 py-2 text-zinc-500">
              HABILIDADES
            </button>
            <button className="px-4 py-2 text-zinc-500">
              RITUAIS
            </button>
            <button className="px-4 py-2 text-zinc-500">
              INVENTÁRIO
            </button>
          </nav>
        </header>

        {/* CONTEÚDO DINÂMICO */}
        <section className="p-6">
          Kit de primeiros socorros
        </section>
      </section>

    </section>
  );
}
