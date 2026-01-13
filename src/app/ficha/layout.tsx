import { Atributos } from "../components/info/header/Atributos";
import { TestesResistencia } from "../components/info/header/TestesResistencia";

export default function FichaLayout() {
  return (
    <section className="flex gap-8 items-start">

      {/* CARD ESQUERDO */}
      <section className="w-[711.6px] rounded-lg border overflow-hidden">

        {/* HEADER */}
        <header className="flex gap-12 border-b p-4 bg-zinc-50">
          <h2 className="sr-only">Atributos e Testes de Resistência</h2>
          <div>  
            <Atributos
              initialData={{
              forca: 3,
              agilidade: 2,
              intelecto: 4,
              vigor: 1,
              presenca: 3,
              instinto: 0,
              }}
            />   
          </div>

          <div>  
            <TestesResistencia
              initialData={{
              fortitude: 3,
              reflexos: 2,
              vontade: 4,
              }}
            />   
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
      <section className="flex-1 max-w-md rounded-lg border overflow-hidden">

        {/* NAVBAR (HEADER) */}
        <header className="border-b bg-zinc-50">
          <nav className="flex">
            <button className="px-4 py-2 font-medium border-b-2 border-black">
              Aba 1
            </button>
            <button className="px-4 py-2 text-zinc-500">
              Aba 2
            </button>
          </nav>
        </header>

        {/* CONTEÚDO DINÂMICO */}
        <section className="p-6">
          Conteúdo da aba selecionada
        </section>
      </section>

    </section>
  );
}
