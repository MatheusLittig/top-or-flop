import axios from 'axios'
import { useCallback } from 'react'
import { Season, Anime } from './interfaces'

export const jikanAPI = axios.create({
  baseURL: 'https://api.jikan.moe/v3'
})

export const getAnimeSeason = async (
  year: number,
  season: string
): Promise<Anime[]> => {
  const response = await jikanAPI
    .get<Season>(`season/${year}/${season}`)
    .then(res => res.data.anime)

  return response.slice(0, 50)
}

export const getAnimeTreending = async (
  year: number,
  season: string
): Promise<Anime[]> => {
  const response = await jikanAPI
    .get<Season>(`season/${year}/${season}`)
    .then(res =>
      res.data.anime.filter(
        anime =>
          anime.score >= 8 &&
          new Date(anime.airing_start).getFullYear() === year
      )
    )

  return response.slice(0, 5)
}
