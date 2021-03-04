import React from 'react'

import { Box, Flex, Grid } from '@chakra-ui/react'
import FeatureTitle from '../components/FeatureTitle'
import SocialBox from '../components/SocialBox'
import FeatureDescription from '../components/FeatureDescription'
import UserInfo from '../components/UserInfo'
import Treending from '../components/Treending'

const Dashboard: React.FC = () => {
  return (
    <Grid
      gridArea="route"
      gridTemplateColumns="1fr 1fr 1fr"
      gridTemplateRows="65px 100px 140px 1fr"
      gridTemplateAreas="
    'header header header'
    'desc desc userInfo'
    'trending trending infoRecomended'
    'topsFlops topsFlops drafts'
    "
      gap={6}
    >
      <Flex gridArea="header" align="top" justify="space-between">
        <FeatureTitle />
        <SocialBox />
      </Flex>

      <FeatureDescription />
      <UserInfo />
      <Treending />
    </Grid>
  )
}

export default Dashboard
