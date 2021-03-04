import React from 'react'

import { Box } from '@chakra-ui/react'
import jikanAPI from '../../services/jikanAPI'

const getSeasonAnime = async () => {
  const season = await jikanAPI.get('season/2021/winter').then(res => res.data)

  console.log(season)
}

const Treending: React.FC = () => {
  return <Box gridArea="trending"></Box>
}

export default Treending
