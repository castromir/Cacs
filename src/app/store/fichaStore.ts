import { create } from 'zustand'

export type AtributosData = {
  forca: number
  agilidade: number
  intelecto: number
  vigor: number
  presenca: number
  instinto: number
}

type FichaState = {
  atributos: AtributosData

  // ações
  setAtributo: (key: keyof AtributosData, value: number) => void
  setAtributos: (atributos: AtributosData) => void
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

  setAtributo: (key, value) =>
    set((state) => ({
      atributos: {
        ...state.atributos,
        [key]: value,
      },
    })),

  setAtributos: (atributos) =>
    set({ atributos }),
}))
