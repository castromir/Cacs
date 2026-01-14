import { create } from 'zustand'

export type AtributosData = {
  forca: number
  agilidade: number
  intelecto: number
  vigor: number
  presenca: number
  instinto: number
}

export type TestesResistenciaData = {
  fortitude: number
  reflexos: number
  vontade: number
}

export type IdentidadeData = {
  nome: string
  classe: string
}

type FichaState = {
  atributos: AtributosData
  testesResistencia: TestesResistenciaData
  identidade: IdentidadeData

  // ações
  setAtributo: (key: keyof AtributosData, value: number) => void
  setAtributos: (atributos: AtributosData) => void

  setTesteResistencia: (
    key: keyof TestesResistenciaData,
     value: number
    ) => void

  setTestesResistencia: (
    testes: TestesResistenciaData
  ) => void

  setIdentidade: <K extends keyof IdentidadeData>(
    key: K,
    value: IdentidadeData[K]
  ) => void
}

export const useFichaStore = create<FichaState>((set) => ({
  atributos: {
    forca: 0,
    agilidade: 0,
    intelecto: 0,
    vigor: 0,
    presenca: 0,
    instinto: 0,
  },

  testesResistencia: {
    fortitude: 0,
    reflexos: 0,
    vontade: 0,
  },
  
  identidade: {
    nome: "Bartô",
    classe: "Ocultista Tecnomante",
  },

  setAtributo: (key, value) =>
    set((state) => ({
      atributos: {
        ...state.atributos,
        [key]: value,
      },
    })),

  setAtributos: (atributos) =>
    set({ atributos }),

  setTesteResistencia: (key, value) =>
    set((state) => ({
      testesResistencia: {
        ...state.testesResistencia,
        [key]: value,
      },
    })),

  setTestesResistencia: (testesResistencia) =>
    set({ testesResistencia }),

   setIdentidade: (key, value) =>
    set((state) => ({
      identidade: {
        ...state.identidade,
        [key]: value,
      },
    })),
}))
